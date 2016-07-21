using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTimeSourceExample : vtkUnstructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTimeSourceExample";

		public new static readonly string MRClassNameKey;

		static vtkTimeSourceExample()
		{
			vtkTimeSourceExample.MRClassNameKey = "class vtkTimeSourceExample";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTimeSourceExample.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTimeSourceExample"));
		}

		public vtkTimeSourceExample(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTimeSourceExample_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTimeSourceExample New()
		{
			vtkTimeSourceExample result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTimeSourceExample.vtkTimeSourceExample_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTimeSourceExample)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTimeSourceExample() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTimeSourceExample.vtkTimeSourceExample_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTimeSourceExample_AnalyticOff_01(HandleRef pThis);

		public virtual void AnalyticOff()
		{
			vtkTimeSourceExample.vtkTimeSourceExample_AnalyticOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTimeSourceExample_AnalyticOn_02(HandleRef pThis);

		public virtual void AnalyticOn()
		{
			vtkTimeSourceExample.vtkTimeSourceExample_AnalyticOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTimeSourceExample_GetAnalytic_03(HandleRef pThis);

		public virtual int GetAnalytic()
		{
			return vtkTimeSourceExample.vtkTimeSourceExample_GetAnalytic_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTimeSourceExample_GetAnalyticMaxValue_04(HandleRef pThis);

		public virtual int GetAnalyticMaxValue()
		{
			return vtkTimeSourceExample.vtkTimeSourceExample_GetAnalyticMaxValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTimeSourceExample_GetAnalyticMinValue_05(HandleRef pThis);

		public virtual int GetAnalyticMinValue()
		{
			return vtkTimeSourceExample.vtkTimeSourceExample_GetAnalyticMinValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTimeSourceExample_GetGrowing_06(HandleRef pThis);

		public virtual int GetGrowing()
		{
			return vtkTimeSourceExample.vtkTimeSourceExample_GetGrowing_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTimeSourceExample_GetGrowingMaxValue_07(HandleRef pThis);

		public virtual int GetGrowingMaxValue()
		{
			return vtkTimeSourceExample.vtkTimeSourceExample_GetGrowingMaxValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTimeSourceExample_GetGrowingMinValue_08(HandleRef pThis);

		public virtual int GetGrowingMinValue()
		{
			return vtkTimeSourceExample.vtkTimeSourceExample_GetGrowingMinValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkTimeSourceExample_GetXAmplitude_09(HandleRef pThis);

		public virtual double GetXAmplitude()
		{
			return vtkTimeSourceExample.vtkTimeSourceExample_GetXAmplitude_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkTimeSourceExample_GetYAmplitude_10(HandleRef pThis);

		public virtual double GetYAmplitude()
		{
			return vtkTimeSourceExample.vtkTimeSourceExample_GetYAmplitude_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTimeSourceExample_GrowingOff_11(HandleRef pThis);

		public virtual void GrowingOff()
		{
			vtkTimeSourceExample.vtkTimeSourceExample_GrowingOff_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTimeSourceExample_GrowingOn_12(HandleRef pThis);

		public virtual void GrowingOn()
		{
			vtkTimeSourceExample.vtkTimeSourceExample_GrowingOn_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTimeSourceExample_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTimeSourceExample.vtkTimeSourceExample_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTimeSourceExample_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTimeSourceExample.vtkTimeSourceExample_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTimeSourceExample_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTimeSourceExample NewInstance()
		{
			vtkTimeSourceExample result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTimeSourceExample.vtkTimeSourceExample_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTimeSourceExample)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTimeSourceExample_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTimeSourceExample SafeDownCast(vtkObjectBase o)
		{
			vtkTimeSourceExample vtkTimeSourceExample = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTimeSourceExample.vtkTimeSourceExample_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTimeSourceExample = (vtkTimeSourceExample)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTimeSourceExample.Register(null);
				}
			}
			return vtkTimeSourceExample;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTimeSourceExample_SetAnalytic_18(HandleRef pThis, int _arg);

		public virtual void SetAnalytic(int _arg)
		{
			vtkTimeSourceExample.vtkTimeSourceExample_SetAnalytic_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTimeSourceExample_SetGrowing_19(HandleRef pThis, int _arg);

		public virtual void SetGrowing(int _arg)
		{
			vtkTimeSourceExample.vtkTimeSourceExample_SetGrowing_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTimeSourceExample_SetXAmplitude_20(HandleRef pThis, double _arg);

		public virtual void SetXAmplitude(double _arg)
		{
			vtkTimeSourceExample.vtkTimeSourceExample_SetXAmplitude_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTimeSourceExample_SetYAmplitude_21(HandleRef pThis, double _arg);

		public virtual void SetYAmplitude(double _arg)
		{
			vtkTimeSourceExample.vtkTimeSourceExample_SetYAmplitude_21(base.GetCppThis(), _arg);
		}
	}
}

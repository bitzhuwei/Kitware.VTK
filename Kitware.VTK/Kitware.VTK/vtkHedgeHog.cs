using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkHedgeHog : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHedgeHog";

		public new static readonly string MRClassNameKey;

		static vtkHedgeHog()
		{
			vtkHedgeHog.MRClassNameKey = "class vtkHedgeHog";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHedgeHog.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHedgeHog"));
		}

		public vtkHedgeHog(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHedgeHog_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHedgeHog New()
		{
			vtkHedgeHog result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHedgeHog.vtkHedgeHog_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHedgeHog)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkHedgeHog() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkHedgeHog.vtkHedgeHog_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkHedgeHog_GetScaleFactor_01(HandleRef pThis);

		public virtual double GetScaleFactor()
		{
			return vtkHedgeHog.vtkHedgeHog_GetScaleFactor_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHedgeHog_GetVectorMode_02(HandleRef pThis);

		public virtual int GetVectorMode()
		{
			return vtkHedgeHog.vtkHedgeHog_GetVectorMode_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHedgeHog_GetVectorModeAsString_03(HandleRef pThis);

		public string GetVectorModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkHedgeHog.vtkHedgeHog_GetVectorModeAsString_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHedgeHog_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHedgeHog.vtkHedgeHog_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHedgeHog_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHedgeHog.vtkHedgeHog_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHedgeHog_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHedgeHog NewInstance()
		{
			vtkHedgeHog result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHedgeHog.vtkHedgeHog_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHedgeHog)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHedgeHog_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHedgeHog SafeDownCast(vtkObjectBase o)
		{
			vtkHedgeHog vtkHedgeHog = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHedgeHog.vtkHedgeHog_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHedgeHog = (vtkHedgeHog)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHedgeHog.Register(null);
				}
			}
			return vtkHedgeHog;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHedgeHog_SetScaleFactor_09(HandleRef pThis, double _arg);

		public virtual void SetScaleFactor(double _arg)
		{
			vtkHedgeHog.vtkHedgeHog_SetScaleFactor_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHedgeHog_SetVectorMode_10(HandleRef pThis, int _arg);

		public virtual void SetVectorMode(int _arg)
		{
			vtkHedgeHog.vtkHedgeHog_SetVectorMode_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHedgeHog_SetVectorModeToUseNormal_11(HandleRef pThis);

		public void SetVectorModeToUseNormal()
		{
			vtkHedgeHog.vtkHedgeHog_SetVectorModeToUseNormal_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHedgeHog_SetVectorModeToUseVector_12(HandleRef pThis);

		public void SetVectorModeToUseVector()
		{
			vtkHedgeHog.vtkHedgeHog_SetVectorModeToUseVector_12(base.GetCppThis());
		}
	}
}

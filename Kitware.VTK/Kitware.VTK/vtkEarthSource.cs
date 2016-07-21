using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkEarthSource : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkEarthSource";

		public new static readonly string MRClassNameKey;

		static vtkEarthSource()
		{
			vtkEarthSource.MRClassNameKey = "class vtkEarthSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEarthSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEarthSource"));
		}

		public vtkEarthSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkEarthSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEarthSource New()
		{
			vtkEarthSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEarthSource.vtkEarthSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEarthSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkEarthSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkEarthSource.vtkEarthSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkEarthSource_GetOnRatio_01(HandleRef pThis);

		public virtual int GetOnRatio()
		{
			return vtkEarthSource.vtkEarthSource_GetOnRatio_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkEarthSource_GetOnRatioMaxValue_02(HandleRef pThis);

		public virtual int GetOnRatioMaxValue()
		{
			return vtkEarthSource.vtkEarthSource_GetOnRatioMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkEarthSource_GetOnRatioMinValue_03(HandleRef pThis);

		public virtual int GetOnRatioMinValue()
		{
			return vtkEarthSource.vtkEarthSource_GetOnRatioMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkEarthSource_GetOutline_04(HandleRef pThis);

		public virtual int GetOutline()
		{
			return vtkEarthSource.vtkEarthSource_GetOutline_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkEarthSource_GetRadius_05(HandleRef pThis);

		public virtual double GetRadius()
		{
			return vtkEarthSource.vtkEarthSource_GetRadius_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkEarthSource_GetRadiusMaxValue_06(HandleRef pThis);

		public virtual double GetRadiusMaxValue()
		{
			return vtkEarthSource.vtkEarthSource_GetRadiusMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkEarthSource_GetRadiusMinValue_07(HandleRef pThis);

		public virtual double GetRadiusMinValue()
		{
			return vtkEarthSource.vtkEarthSource_GetRadiusMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkEarthSource_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkEarthSource.vtkEarthSource_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkEarthSource_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkEarthSource.vtkEarthSource_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkEarthSource_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkEarthSource NewInstance()
		{
			vtkEarthSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEarthSource.vtkEarthSource_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEarthSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkEarthSource_OutlineOff_12(HandleRef pThis);

		public virtual void OutlineOff()
		{
			vtkEarthSource.vtkEarthSource_OutlineOff_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkEarthSource_OutlineOn_13(HandleRef pThis);

		public virtual void OutlineOn()
		{
			vtkEarthSource.vtkEarthSource_OutlineOn_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkEarthSource_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEarthSource SafeDownCast(vtkObjectBase o)
		{
			vtkEarthSource vtkEarthSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEarthSource.vtkEarthSource_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEarthSource = (vtkEarthSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEarthSource.Register(null);
				}
			}
			return vtkEarthSource;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkEarthSource_SetOnRatio_15(HandleRef pThis, int _arg);

		public virtual void SetOnRatio(int _arg)
		{
			vtkEarthSource.vtkEarthSource_SetOnRatio_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkEarthSource_SetOutline_16(HandleRef pThis, int _arg);

		public virtual void SetOutline(int _arg)
		{
			vtkEarthSource.vtkEarthSource_SetOutline_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkEarthSource_SetRadius_17(HandleRef pThis, double _arg);

		public virtual void SetRadius(double _arg)
		{
			vtkEarthSource.vtkEarthSource_SetRadius_17(base.GetCppThis(), _arg);
		}
	}
}

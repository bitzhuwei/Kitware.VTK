using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCylinderSource : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCylinderSource";

		public new static readonly string MRClassNameKey;

		static vtkCylinderSource()
		{
			vtkCylinderSource.MRClassNameKey = "class vtkCylinderSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCylinderSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCylinderSource"));
		}

		public vtkCylinderSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCylinderSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCylinderSource New()
		{
			vtkCylinderSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCylinderSource.vtkCylinderSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCylinderSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCylinderSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCylinderSource.vtkCylinderSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCylinderSource_CappingOff_01(HandleRef pThis);

		public virtual void CappingOff()
		{
			vtkCylinderSource.vtkCylinderSource_CappingOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCylinderSource_CappingOn_02(HandleRef pThis);

		public virtual void CappingOn()
		{
			vtkCylinderSource.vtkCylinderSource_CappingOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCylinderSource_GetCapping_03(HandleRef pThis);

		public virtual int GetCapping()
		{
			return vtkCylinderSource.vtkCylinderSource_GetCapping_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCylinderSource_GetCenter_04(HandleRef pThis);

		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkCylinderSource.vtkCylinderSource_GetCenter_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCylinderSource_GetCenter_05(HandleRef pThis, IntPtr data);

		public virtual void GetCenter(IntPtr data)
		{
			vtkCylinderSource.vtkCylinderSource_GetCenter_05(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkCylinderSource_GetHeight_06(HandleRef pThis);

		public virtual double GetHeight()
		{
			return vtkCylinderSource.vtkCylinderSource_GetHeight_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkCylinderSource_GetHeightMaxValue_07(HandleRef pThis);

		public virtual double GetHeightMaxValue()
		{
			return vtkCylinderSource.vtkCylinderSource_GetHeightMaxValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkCylinderSource_GetHeightMinValue_08(HandleRef pThis);

		public virtual double GetHeightMinValue()
		{
			return vtkCylinderSource.vtkCylinderSource_GetHeightMinValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkCylinderSource_GetRadius_09(HandleRef pThis);

		public virtual double GetRadius()
		{
			return vtkCylinderSource.vtkCylinderSource_GetRadius_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkCylinderSource_GetRadiusMaxValue_10(HandleRef pThis);

		public virtual double GetRadiusMaxValue()
		{
			return vtkCylinderSource.vtkCylinderSource_GetRadiusMaxValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkCylinderSource_GetRadiusMinValue_11(HandleRef pThis);

		public virtual double GetRadiusMinValue()
		{
			return vtkCylinderSource.vtkCylinderSource_GetRadiusMinValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCylinderSource_GetResolution_12(HandleRef pThis);

		public virtual int GetResolution()
		{
			return vtkCylinderSource.vtkCylinderSource_GetResolution_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCylinderSource_GetResolutionMaxValue_13(HandleRef pThis);

		public virtual int GetResolutionMaxValue()
		{
			return vtkCylinderSource.vtkCylinderSource_GetResolutionMaxValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCylinderSource_GetResolutionMinValue_14(HandleRef pThis);

		public virtual int GetResolutionMinValue()
		{
			return vtkCylinderSource.vtkCylinderSource_GetResolutionMinValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCylinderSource_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCylinderSource.vtkCylinderSource_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCylinderSource_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCylinderSource.vtkCylinderSource_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCylinderSource_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCylinderSource NewInstance()
		{
			vtkCylinderSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCylinderSource.vtkCylinderSource_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCylinderSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCylinderSource_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCylinderSource SafeDownCast(vtkObjectBase o)
		{
			vtkCylinderSource vtkCylinderSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCylinderSource.vtkCylinderSource_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCylinderSource = (vtkCylinderSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCylinderSource.Register(null);
				}
			}
			return vtkCylinderSource;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCylinderSource_SetCapping_20(HandleRef pThis, int _arg);

		public virtual void SetCapping(int _arg)
		{
			vtkCylinderSource.vtkCylinderSource_SetCapping_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCylinderSource_SetCenter_21(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkCylinderSource.vtkCylinderSource_SetCenter_21(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCylinderSource_SetCenter_22(HandleRef pThis, IntPtr _arg);

		public virtual void SetCenter(IntPtr _arg)
		{
			vtkCylinderSource.vtkCylinderSource_SetCenter_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCylinderSource_SetHeight_23(HandleRef pThis, double _arg);

		public virtual void SetHeight(double _arg)
		{
			vtkCylinderSource.vtkCylinderSource_SetHeight_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCylinderSource_SetRadius_24(HandleRef pThis, double _arg);

		public virtual void SetRadius(double _arg)
		{
			vtkCylinderSource.vtkCylinderSource_SetRadius_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCylinderSource_SetResolution_25(HandleRef pThis, int _arg);

		public virtual void SetResolution(int _arg)
		{
			vtkCylinderSource.vtkCylinderSource_SetResolution_25(base.GetCppThis(), _arg);
		}
	}
}

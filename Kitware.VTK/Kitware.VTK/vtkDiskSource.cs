using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDiskSource : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDiskSource";

		public new static readonly string MRClassNameKey;

		static vtkDiskSource()
		{
			vtkDiskSource.MRClassNameKey = "class vtkDiskSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDiskSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDiskSource"));
		}

		public vtkDiskSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDiskSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDiskSource New()
		{
			vtkDiskSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDiskSource.vtkDiskSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDiskSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDiskSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDiskSource.vtkDiskSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDiskSource_GetCircumferentialResolution_01(HandleRef pThis);

		public virtual int GetCircumferentialResolution()
		{
			return vtkDiskSource.vtkDiskSource_GetCircumferentialResolution_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDiskSource_GetCircumferentialResolutionMaxValue_02(HandleRef pThis);

		public virtual int GetCircumferentialResolutionMaxValue()
		{
			return vtkDiskSource.vtkDiskSource_GetCircumferentialResolutionMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDiskSource_GetCircumferentialResolutionMinValue_03(HandleRef pThis);

		public virtual int GetCircumferentialResolutionMinValue()
		{
			return vtkDiskSource.vtkDiskSource_GetCircumferentialResolutionMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDiskSource_GetInnerRadius_04(HandleRef pThis);

		public virtual double GetInnerRadius()
		{
			return vtkDiskSource.vtkDiskSource_GetInnerRadius_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDiskSource_GetInnerRadiusMaxValue_05(HandleRef pThis);

		public virtual double GetInnerRadiusMaxValue()
		{
			return vtkDiskSource.vtkDiskSource_GetInnerRadiusMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDiskSource_GetInnerRadiusMinValue_06(HandleRef pThis);

		public virtual double GetInnerRadiusMinValue()
		{
			return vtkDiskSource.vtkDiskSource_GetInnerRadiusMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDiskSource_GetOuterRadius_07(HandleRef pThis);

		public virtual double GetOuterRadius()
		{
			return vtkDiskSource.vtkDiskSource_GetOuterRadius_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDiskSource_GetOuterRadiusMaxValue_08(HandleRef pThis);

		public virtual double GetOuterRadiusMaxValue()
		{
			return vtkDiskSource.vtkDiskSource_GetOuterRadiusMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDiskSource_GetOuterRadiusMinValue_09(HandleRef pThis);

		public virtual double GetOuterRadiusMinValue()
		{
			return vtkDiskSource.vtkDiskSource_GetOuterRadiusMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDiskSource_GetRadialResolution_10(HandleRef pThis);

		public virtual int GetRadialResolution()
		{
			return vtkDiskSource.vtkDiskSource_GetRadialResolution_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDiskSource_GetRadialResolutionMaxValue_11(HandleRef pThis);

		public virtual int GetRadialResolutionMaxValue()
		{
			return vtkDiskSource.vtkDiskSource_GetRadialResolutionMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDiskSource_GetRadialResolutionMinValue_12(HandleRef pThis);

		public virtual int GetRadialResolutionMinValue()
		{
			return vtkDiskSource.vtkDiskSource_GetRadialResolutionMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDiskSource_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDiskSource.vtkDiskSource_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDiskSource_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDiskSource.vtkDiskSource_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDiskSource_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDiskSource NewInstance()
		{
			vtkDiskSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDiskSource.vtkDiskSource_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDiskSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDiskSource_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDiskSource SafeDownCast(vtkObjectBase o)
		{
			vtkDiskSource vtkDiskSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDiskSource.vtkDiskSource_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDiskSource = (vtkDiskSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDiskSource.Register(null);
				}
			}
			return vtkDiskSource;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDiskSource_SetCircumferentialResolution_18(HandleRef pThis, int _arg);

		public virtual void SetCircumferentialResolution(int _arg)
		{
			vtkDiskSource.vtkDiskSource_SetCircumferentialResolution_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDiskSource_SetInnerRadius_19(HandleRef pThis, double _arg);

		public virtual void SetInnerRadius(double _arg)
		{
			vtkDiskSource.vtkDiskSource_SetInnerRadius_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDiskSource_SetOuterRadius_20(HandleRef pThis, double _arg);

		public virtual void SetOuterRadius(double _arg)
		{
			vtkDiskSource.vtkDiskSource_SetOuterRadius_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDiskSource_SetRadialResolution_21(HandleRef pThis, int _arg);

		public virtual void SetRadialResolution(int _arg)
		{
			vtkDiskSource.vtkDiskSource_SetRadialResolution_21(base.GetCppThis(), _arg);
		}
	}
}

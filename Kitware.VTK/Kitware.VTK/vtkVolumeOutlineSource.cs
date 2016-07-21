using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkVolumeOutlineSource : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeOutlineSource";

		public new static readonly string MRClassNameKey;

		static vtkVolumeOutlineSource()
		{
			vtkVolumeOutlineSource.MRClassNameKey = "class vtkVolumeOutlineSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolumeOutlineSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeOutlineSource"));
		}

		public vtkVolumeOutlineSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeOutlineSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolumeOutlineSource New()
		{
			vtkVolumeOutlineSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeOutlineSource.vtkVolumeOutlineSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeOutlineSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkVolumeOutlineSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkVolumeOutlineSource.vtkVolumeOutlineSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeOutlineSource_GenerateFacesOff_01(HandleRef pThis);

		public virtual void GenerateFacesOff()
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_GenerateFacesOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeOutlineSource_GenerateFacesOn_02(HandleRef pThis);

		public virtual void GenerateFacesOn()
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_GenerateFacesOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeOutlineSource_GenerateOutlineOff_03(HandleRef pThis);

		public virtual void GenerateOutlineOff()
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_GenerateOutlineOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeOutlineSource_GenerateOutlineOn_04(HandleRef pThis);

		public virtual void GenerateOutlineOn()
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_GenerateOutlineOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeOutlineSource_GenerateScalarsOff_05(HandleRef pThis);

		public virtual void GenerateScalarsOff()
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_GenerateScalarsOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeOutlineSource_GenerateScalarsOn_06(HandleRef pThis);

		public virtual void GenerateScalarsOn()
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_GenerateScalarsOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeOutlineSource_GetActivePlaneColor_07(HandleRef pThis);

		public virtual double[] GetActivePlaneColor()
		{
			IntPtr intPtr = vtkVolumeOutlineSource.vtkVolumeOutlineSource_GetActivePlaneColor_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeOutlineSource_GetActivePlaneColor_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetActivePlaneColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_GetActivePlaneColor_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeOutlineSource_GetActivePlaneColor_09(HandleRef pThis, IntPtr _arg);

		public virtual void GetActivePlaneColor(IntPtr _arg)
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_GetActivePlaneColor_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeOutlineSource_GetActivePlaneId_10(HandleRef pThis);

		public virtual int GetActivePlaneId()
		{
			return vtkVolumeOutlineSource.vtkVolumeOutlineSource_GetActivePlaneId_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeOutlineSource_GetColor_11(HandleRef pThis);

		public virtual double[] GetColor()
		{
			IntPtr intPtr = vtkVolumeOutlineSource.vtkVolumeOutlineSource_GetColor_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeOutlineSource_GetColor_12(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_GetColor_12(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeOutlineSource_GetColor_13(HandleRef pThis, IntPtr _arg);

		public virtual void GetColor(IntPtr _arg)
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_GetColor_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeOutlineSource_GetGenerateFaces_14(HandleRef pThis);

		public virtual int GetGenerateFaces()
		{
			return vtkVolumeOutlineSource.vtkVolumeOutlineSource_GetGenerateFaces_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeOutlineSource_GetGenerateOutline_15(HandleRef pThis);

		public virtual int GetGenerateOutline()
		{
			return vtkVolumeOutlineSource.vtkVolumeOutlineSource_GetGenerateOutline_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeOutlineSource_GetGenerateScalars_16(HandleRef pThis);

		public virtual int GetGenerateScalars()
		{
			return vtkVolumeOutlineSource.vtkVolumeOutlineSource_GetGenerateScalars_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeOutlineSource_GetVolumeMapper_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkVolumeMapper GetVolumeMapper()
		{
			vtkVolumeMapper vtkVolumeMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeOutlineSource.vtkVolumeOutlineSource_GetVolumeMapper_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeMapper = (vtkVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeMapper.Register(null);
				}
			}
			return vtkVolumeMapper;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeOutlineSource_IsA_18(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVolumeOutlineSource.vtkVolumeOutlineSource_IsA_18(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeOutlineSource_IsTypeOf_19(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVolumeOutlineSource.vtkVolumeOutlineSource_IsTypeOf_19(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeOutlineSource_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVolumeOutlineSource NewInstance()
		{
			vtkVolumeOutlineSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeOutlineSource.vtkVolumeOutlineSource_NewInstance_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeOutlineSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeOutlineSource_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolumeOutlineSource SafeDownCast(vtkObjectBase o)
		{
			vtkVolumeOutlineSource vtkVolumeOutlineSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeOutlineSource.vtkVolumeOutlineSource_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeOutlineSource = (vtkVolumeOutlineSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeOutlineSource.Register(null);
				}
			}
			return vtkVolumeOutlineSource;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeOutlineSource_SetActivePlaneColor_23(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetActivePlaneColor(double _arg1, double _arg2, double _arg3)
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_SetActivePlaneColor_23(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeOutlineSource_SetActivePlaneColor_24(HandleRef pThis, IntPtr _arg);

		public virtual void SetActivePlaneColor(IntPtr _arg)
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_SetActivePlaneColor_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeOutlineSource_SetActivePlaneId_25(HandleRef pThis, int _arg);

		public virtual void SetActivePlaneId(int _arg)
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_SetActivePlaneId_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeOutlineSource_SetColor_26(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetColor(double _arg1, double _arg2, double _arg3)
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_SetColor_26(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeOutlineSource_SetColor_27(HandleRef pThis, IntPtr _arg);

		public virtual void SetColor(IntPtr _arg)
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_SetColor_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeOutlineSource_SetGenerateFaces_28(HandleRef pThis, int _arg);

		public virtual void SetGenerateFaces(int _arg)
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_SetGenerateFaces_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeOutlineSource_SetGenerateOutline_29(HandleRef pThis, int _arg);

		public virtual void SetGenerateOutline(int _arg)
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_SetGenerateOutline_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeOutlineSource_SetGenerateScalars_30(HandleRef pThis, int _arg);

		public virtual void SetGenerateScalars(int _arg)
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_SetGenerateScalars_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeOutlineSource_SetVolumeMapper_31(HandleRef pThis, HandleRef mapper);

		public virtual void SetVolumeMapper(vtkVolumeMapper mapper)
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_SetVolumeMapper_31(base.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis());
		}
	}
}

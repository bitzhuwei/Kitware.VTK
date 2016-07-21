using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractCTHPart : vtkMultiBlockDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractCTHPart";

		public new static readonly string MRClassNameKey;

		static vtkExtractCTHPart()
		{
			vtkExtractCTHPart.MRClassNameKey = "class vtkExtractCTHPart";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractCTHPart.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractCTHPart"));
		}

		public vtkExtractCTHPart(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractCTHPart_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractCTHPart New()
		{
			vtkExtractCTHPart result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractCTHPart.vtkExtractCTHPart_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractCTHPart)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtractCTHPart() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtractCTHPart.vtkExtractCTHPart_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExtractCTHPart_AddDoubleVolumeArrayName_01(HandleRef pThis, string arrayName);

		public void AddDoubleVolumeArrayName(string arrayName)
		{
			vtkExtractCTHPart.vtkExtractCTHPart_AddDoubleVolumeArrayName_01(base.GetCppThis(), arrayName);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExtractCTHPart_AddFloatVolumeArrayName_02(HandleRef pThis, string arrayName);

		public void AddFloatVolumeArrayName(string arrayName)
		{
			vtkExtractCTHPart.vtkExtractCTHPart_AddFloatVolumeArrayName_02(base.GetCppThis(), arrayName);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExtractCTHPart_AddUnsignedCharVolumeArrayName_03(HandleRef pThis, string arrayName);

		public void AddUnsignedCharVolumeArrayName(string arrayName)
		{
			vtkExtractCTHPart.vtkExtractCTHPart_AddUnsignedCharVolumeArrayName_03(base.GetCppThis(), arrayName);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExtractCTHPart_AddVolumeArrayName_04(HandleRef pThis, string arrayName);

		public void AddVolumeArrayName(string arrayName)
		{
			vtkExtractCTHPart.vtkExtractCTHPart_AddVolumeArrayName_04(base.GetCppThis(), arrayName);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractCTHPart_BOUNDS_05(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationDoubleVectorKey BOUNDS()
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractCTHPart.vtkExtractCTHPart_BOUNDS_05(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleVectorKey = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleVectorKey.Register(null);
				}
			}
			return vtkInformationDoubleVectorKey;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractCTHPart_GetClipPlane_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPlane GetClipPlane()
		{
			vtkPlane vtkPlane = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractCTHPart.vtkExtractCTHPart_GetClipPlane_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlane = (vtkPlane)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlane.Register(null);
				}
			}
			return vtkPlane;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractCTHPart_GetController_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractCTHPart.vtkExtractCTHPart_GetController_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern uint vtkExtractCTHPart_GetMTime_08(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkExtractCTHPart.vtkExtractCTHPart_GetMTime_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkExtractCTHPart_GetNumberOfVolumeArrayNames_09(HandleRef pThis);

		public int GetNumberOfVolumeArrayNames()
		{
			return vtkExtractCTHPart.vtkExtractCTHPart_GetNumberOfVolumeArrayNames_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractCTHPart_GetVolumeArrayName_10(HandleRef pThis, int idx);

		public string GetVolumeArrayName(int idx)
		{
			return Marshal.PtrToStringAnsi(vtkExtractCTHPart.vtkExtractCTHPart_GetVolumeArrayName_10(base.GetCppThis(), idx));
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern double vtkExtractCTHPart_GetVolumeFractionSurfaceValue_11(HandleRef pThis);

		public virtual double GetVolumeFractionSurfaceValue()
		{
			return vtkExtractCTHPart.vtkExtractCTHPart_GetVolumeFractionSurfaceValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern double vtkExtractCTHPart_GetVolumeFractionSurfaceValueMaxValue_12(HandleRef pThis);

		public virtual double GetVolumeFractionSurfaceValueMaxValue()
		{
			return vtkExtractCTHPart.vtkExtractCTHPart_GetVolumeFractionSurfaceValueMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern double vtkExtractCTHPart_GetVolumeFractionSurfaceValueMinValue_13(HandleRef pThis);

		public virtual double GetVolumeFractionSurfaceValueMinValue()
		{
			return vtkExtractCTHPart.vtkExtractCTHPart_GetVolumeFractionSurfaceValueMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkExtractCTHPart_IsA_14(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractCTHPart.vtkExtractCTHPart_IsA_14(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkExtractCTHPart_IsTypeOf_15(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractCTHPart.vtkExtractCTHPart_IsTypeOf_15(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractCTHPart_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractCTHPart NewInstance()
		{
			vtkExtractCTHPart result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractCTHPart.vtkExtractCTHPart_NewInstance_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractCTHPart)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExtractCTHPart_RemoveAllVolumeArrayNames_18(HandleRef pThis);

		public void RemoveAllVolumeArrayNames()
		{
			vtkExtractCTHPart.vtkExtractCTHPart_RemoveAllVolumeArrayNames_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExtractCTHPart_RemoveDoubleVolumeArrayNames_19(HandleRef pThis);

		public void RemoveDoubleVolumeArrayNames()
		{
			vtkExtractCTHPart.vtkExtractCTHPart_RemoveDoubleVolumeArrayNames_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExtractCTHPart_RemoveFloatVolumeArrayNames_20(HandleRef pThis);

		public void RemoveFloatVolumeArrayNames()
		{
			vtkExtractCTHPart.vtkExtractCTHPart_RemoveFloatVolumeArrayNames_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExtractCTHPart_RemoveUnsignedCharVolumeArrayNames_21(HandleRef pThis);

		public void RemoveUnsignedCharVolumeArrayNames()
		{
			vtkExtractCTHPart.vtkExtractCTHPart_RemoveUnsignedCharVolumeArrayNames_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractCTHPart_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractCTHPart SafeDownCast(vtkObjectBase o)
		{
			vtkExtractCTHPart vtkExtractCTHPart = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractCTHPart.vtkExtractCTHPart_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractCTHPart = (vtkExtractCTHPart)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractCTHPart.Register(null);
				}
			}
			return vtkExtractCTHPart;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExtractCTHPart_SetClipPlane_23(HandleRef pThis, HandleRef clipPlane);

		public void SetClipPlane(vtkPlane clipPlane)
		{
			vtkExtractCTHPart.vtkExtractCTHPart_SetClipPlane_23(base.GetCppThis(), (clipPlane == null) ? default(HandleRef) : clipPlane.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExtractCTHPart_SetController_24(HandleRef pThis, HandleRef controller);

		public void SetController(vtkMultiProcessController controller)
		{
			vtkExtractCTHPart.vtkExtractCTHPart_SetController_24(base.GetCppThis(), (controller == null) ? default(HandleRef) : controller.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExtractCTHPart_SetVolumeFractionSurfaceValue_25(HandleRef pThis, double _arg);

		public virtual void SetVolumeFractionSurfaceValue(double _arg)
		{
			vtkExtractCTHPart.vtkExtractCTHPart_SetVolumeFractionSurfaceValue_25(base.GetCppThis(), _arg);
		}
	}
}

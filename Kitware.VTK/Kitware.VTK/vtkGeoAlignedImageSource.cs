using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGeoAlignedImageSource : vtkGeoSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoAlignedImageSource";

		public new static readonly string MRClassNameKey;

		static vtkGeoAlignedImageSource()
		{
			vtkGeoAlignedImageSource.MRClassNameKey = "class vtkGeoAlignedImageSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoAlignedImageSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoAlignedImageSource"));
		}

		public vtkGeoAlignedImageSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoAlignedImageSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoAlignedImageSource New()
		{
			vtkGeoAlignedImageSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoAlignedImageSource.vtkGeoAlignedImageSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoAlignedImageSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGeoAlignedImageSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGeoAlignedImageSource.vtkGeoAlignedImageSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern byte vtkGeoAlignedImageSource_FetchChild_01(HandleRef pThis, HandleRef parent, int index, HandleRef child);

		public override bool FetchChild(vtkGeoTreeNode parent, int index, vtkGeoTreeNode child)
		{
			return vtkGeoAlignedImageSource.vtkGeoAlignedImageSource_FetchChild_01(base.GetCppThis(), (parent == null) ? default(HandleRef) : parent.GetCppThis(), index, (child == null) ? default(HandleRef) : child.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern byte vtkGeoAlignedImageSource_FetchRoot_02(HandleRef pThis, HandleRef node);

		public override bool FetchRoot(vtkGeoTreeNode node)
		{
			return vtkGeoAlignedImageSource.vtkGeoAlignedImageSource_FetchRoot_02(base.GetCppThis(), (node == null) ? default(HandleRef) : node.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoAlignedImageSource_GetImage_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageData GetImage()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoAlignedImageSource.vtkGeoAlignedImageSource_GetImage_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoAlignedImageSource_GetLatitudeRange_04(HandleRef pThis);

		public virtual double[] GetLatitudeRange()
		{
			IntPtr intPtr = vtkGeoAlignedImageSource.vtkGeoAlignedImageSource_GetLatitudeRange_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoAlignedImageSource_GetLatitudeRange_05(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetLatitudeRange(ref double _arg1, ref double _arg2)
		{
			vtkGeoAlignedImageSource.vtkGeoAlignedImageSource_GetLatitudeRange_05(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoAlignedImageSource_GetLatitudeRange_06(HandleRef pThis, IntPtr _arg);

		public virtual void GetLatitudeRange(IntPtr _arg)
		{
			vtkGeoAlignedImageSource.vtkGeoAlignedImageSource_GetLatitudeRange_06(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoAlignedImageSource_GetLongitudeRange_07(HandleRef pThis);

		public virtual double[] GetLongitudeRange()
		{
			IntPtr intPtr = vtkGeoAlignedImageSource.vtkGeoAlignedImageSource_GetLongitudeRange_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoAlignedImageSource_GetLongitudeRange_08(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetLongitudeRange(ref double _arg1, ref double _arg2)
		{
			vtkGeoAlignedImageSource.vtkGeoAlignedImageSource_GetLongitudeRange_08(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoAlignedImageSource_GetLongitudeRange_09(HandleRef pThis, IntPtr _arg);

		public virtual void GetLongitudeRange(IntPtr _arg)
		{
			vtkGeoAlignedImageSource.vtkGeoAlignedImageSource_GetLongitudeRange_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGeoAlignedImageSource_GetOverlap_10(HandleRef pThis);

		public virtual double GetOverlap()
		{
			return vtkGeoAlignedImageSource.vtkGeoAlignedImageSource_GetOverlap_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGeoAlignedImageSource_GetOverlapMaxValue_11(HandleRef pThis);

		public virtual double GetOverlapMaxValue()
		{
			return vtkGeoAlignedImageSource.vtkGeoAlignedImageSource_GetOverlapMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGeoAlignedImageSource_GetOverlapMinValue_12(HandleRef pThis);

		public virtual double GetOverlapMinValue()
		{
			return vtkGeoAlignedImageSource.vtkGeoAlignedImageSource_GetOverlapMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern byte vtkGeoAlignedImageSource_GetPowerOfTwoSize_13(HandleRef pThis);

		public virtual bool GetPowerOfTwoSize()
		{
			return vtkGeoAlignedImageSource.vtkGeoAlignedImageSource_GetPowerOfTwoSize_13(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoAlignedImageSource_IsA_14(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeoAlignedImageSource.vtkGeoAlignedImageSource_IsA_14(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoAlignedImageSource_IsTypeOf_15(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeoAlignedImageSource.vtkGeoAlignedImageSource_IsTypeOf_15(type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoAlignedImageSource_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeoAlignedImageSource NewInstance()
		{
			vtkGeoAlignedImageSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoAlignedImageSource.vtkGeoAlignedImageSource_NewInstance_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoAlignedImageSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoAlignedImageSource_PowerOfTwoSizeOff_18(HandleRef pThis);

		public virtual void PowerOfTwoSizeOff()
		{
			vtkGeoAlignedImageSource.vtkGeoAlignedImageSource_PowerOfTwoSizeOff_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoAlignedImageSource_PowerOfTwoSizeOn_19(HandleRef pThis);

		public virtual void PowerOfTwoSizeOn()
		{
			vtkGeoAlignedImageSource.vtkGeoAlignedImageSource_PowerOfTwoSizeOn_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoAlignedImageSource_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoAlignedImageSource SafeDownCast(vtkObjectBase o)
		{
			vtkGeoAlignedImageSource vtkGeoAlignedImageSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoAlignedImageSource.vtkGeoAlignedImageSource_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoAlignedImageSource = (vtkGeoAlignedImageSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoAlignedImageSource.Register(null);
				}
			}
			return vtkGeoAlignedImageSource;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoAlignedImageSource_SetImage_21(HandleRef pThis, HandleRef image);

		public virtual void SetImage(vtkImageData image)
		{
			vtkGeoAlignedImageSource.vtkGeoAlignedImageSource_SetImage_21(base.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoAlignedImageSource_SetLatitudeRange_22(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetLatitudeRange(double _arg1, double _arg2)
		{
			vtkGeoAlignedImageSource.vtkGeoAlignedImageSource_SetLatitudeRange_22(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoAlignedImageSource_SetLatitudeRange_23(HandleRef pThis, IntPtr _arg);

		public void SetLatitudeRange(IntPtr _arg)
		{
			vtkGeoAlignedImageSource.vtkGeoAlignedImageSource_SetLatitudeRange_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoAlignedImageSource_SetLongitudeRange_24(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetLongitudeRange(double _arg1, double _arg2)
		{
			vtkGeoAlignedImageSource.vtkGeoAlignedImageSource_SetLongitudeRange_24(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoAlignedImageSource_SetLongitudeRange_25(HandleRef pThis, IntPtr _arg);

		public void SetLongitudeRange(IntPtr _arg)
		{
			vtkGeoAlignedImageSource.vtkGeoAlignedImageSource_SetLongitudeRange_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoAlignedImageSource_SetOverlap_26(HandleRef pThis, double _arg);

		public virtual void SetOverlap(double _arg)
		{
			vtkGeoAlignedImageSource.vtkGeoAlignedImageSource_SetOverlap_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoAlignedImageSource_SetPowerOfTwoSize_27(HandleRef pThis, byte _arg);

		public virtual void SetPowerOfTwoSize(bool _arg)
		{
			vtkGeoAlignedImageSource.vtkGeoAlignedImageSource_SetPowerOfTwoSize_27(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}
	}
}

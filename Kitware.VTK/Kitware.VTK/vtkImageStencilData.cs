using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageStencilData : vtkDataObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageStencilData";

		public new static readonly string MRClassNameKey;

		static vtkImageStencilData()
		{
			vtkImageStencilData.MRClassNameKey = "class vtkImageStencilData";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageStencilData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageStencilData"));
		}

		public vtkImageStencilData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageStencilData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageStencilData New()
		{
			vtkImageStencilData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageStencilData.vtkImageStencilData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageStencilData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageStencilData.vtkImageStencilData_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilData_Add_01(HandleRef pThis, HandleRef arg0);

		public virtual void Add(vtkImageStencilData arg0)
		{
			vtkImageStencilData.vtkImageStencilData_Add_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilData_AllocateExtents_02(HandleRef pThis);

		public void AllocateExtents()
		{
			vtkImageStencilData.vtkImageStencilData_AllocateExtents_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageStencilData_Clip_03(HandleRef pThis, IntPtr extent);

		public virtual int Clip(IntPtr extent)
		{
			return vtkImageStencilData.vtkImageStencilData_Clip_03(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilData_CopyInformationFromPipeline_04(HandleRef pThis, HandleRef request);

		public override void CopyInformationFromPipeline(vtkInformation request)
		{
			vtkImageStencilData.vtkImageStencilData_CopyInformationFromPipeline_04(base.GetCppThis(), (request == null) ? default(HandleRef) : request.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilData_CopyInformationToPipeline_05(HandleRef pThis, HandleRef request, HandleRef input, HandleRef output, int forceCopy);

		public override void CopyInformationToPipeline(vtkInformation request, vtkInformation input, vtkInformation output, int forceCopy)
		{
			vtkImageStencilData.vtkImageStencilData_CopyInformationToPipeline_05(base.GetCppThis(), (request == null) ? default(HandleRef) : request.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis(), forceCopy);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilData_DeepCopy_06(HandleRef pThis, HandleRef o);

		public override void DeepCopy(vtkDataObject o)
		{
			vtkImageStencilData.vtkImageStencilData_DeepCopy_06(base.GetCppThis(), (o == null) ? default(HandleRef) : o.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilData_Fill_07(HandleRef pThis);

		public void Fill()
		{
			vtkImageStencilData.vtkImageStencilData_Fill_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageStencilData_GetData_08(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageStencilData GetData(vtkInformation info)
		{
			vtkImageStencilData vtkImageStencilData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageStencilData.vtkImageStencilData_GetData_08((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageStencilData = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageStencilData.Register(null);
				}
			}
			return vtkImageStencilData;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageStencilData_GetData_09(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageStencilData GetData(vtkInformationVector v, int i)
		{
			vtkImageStencilData vtkImageStencilData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageStencilData.vtkImageStencilData_GetData_09((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageStencilData = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageStencilData.Register(null);
				}
			}
			return vtkImageStencilData;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageStencilData_GetDataObjectType_10(HandleRef pThis);

		public override int GetDataObjectType()
		{
			return vtkImageStencilData.vtkImageStencilData_GetDataObjectType_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageStencilData_GetExtent_11(HandleRef pThis);

		public virtual int[] GetExtent()
		{
			IntPtr intPtr = vtkImageStencilData.vtkImageStencilData_GetExtent_11(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilData_GetExtent_12(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		public virtual void GetExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkImageStencilData.vtkImageStencilData_GetExtent_12(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilData_GetExtent_13(HandleRef pThis, IntPtr _arg);

		public virtual void GetExtent(IntPtr _arg)
		{
			vtkImageStencilData.vtkImageStencilData_GetExtent_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageStencilData_GetExtentType_14(HandleRef pThis);

		public override int GetExtentType()
		{
			return vtkImageStencilData.vtkImageStencilData_GetExtentType_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageStencilData_GetNextExtent_15(HandleRef pThis, ref int r1, ref int r2, int xMin, int xMax, int yIdx, int zIdx, ref int iter);

		public int GetNextExtent(ref int r1, ref int r2, int xMin, int xMax, int yIdx, int zIdx, ref int iter)
		{
			return vtkImageStencilData.vtkImageStencilData_GetNextExtent_15(base.GetCppThis(), ref r1, ref r2, xMin, xMax, yIdx, zIdx, ref iter);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageStencilData_GetOrigin_16(HandleRef pThis);

		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkImageStencilData.vtkImageStencilData_GetOrigin_16(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilData_GetOrigin_17(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageStencilData.vtkImageStencilData_GetOrigin_17(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilData_GetOrigin_18(HandleRef pThis, IntPtr _arg);

		public virtual void GetOrigin(IntPtr _arg)
		{
			vtkImageStencilData.vtkImageStencilData_GetOrigin_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageStencilData_GetSpacing_19(HandleRef pThis);

		public virtual double[] GetSpacing()
		{
			IntPtr intPtr = vtkImageStencilData.vtkImageStencilData_GetSpacing_19(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilData_GetSpacing_20(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageStencilData.vtkImageStencilData_GetSpacing_20(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilData_GetSpacing_21(HandleRef pThis, IntPtr _arg);

		public virtual void GetSpacing(IntPtr _arg)
		{
			vtkImageStencilData.vtkImageStencilData_GetSpacing_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilData_Initialize_22(HandleRef pThis);

		public override void Initialize()
		{
			vtkImageStencilData.vtkImageStencilData_Initialize_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilData_InsertAndMergeExtent_23(HandleRef pThis, int r1, int r2, int yIdx, int zIdx);

		public void InsertAndMergeExtent(int r1, int r2, int yIdx, int zIdx)
		{
			vtkImageStencilData.vtkImageStencilData_InsertAndMergeExtent_23(base.GetCppThis(), r1, r2, yIdx, zIdx);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilData_InsertNextExtent_24(HandleRef pThis, int r1, int r2, int yIdx, int zIdx);

		public void InsertNextExtent(int r1, int r2, int yIdx, int zIdx)
		{
			vtkImageStencilData.vtkImageStencilData_InsertNextExtent_24(base.GetCppThis(), r1, r2, yIdx, zIdx);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilData_InternalImageStencilDataCopy_25(HandleRef pThis, HandleRef s);

		public void InternalImageStencilDataCopy(vtkImageStencilData s)
		{
			vtkImageStencilData.vtkImageStencilData_InternalImageStencilDataCopy_25(base.GetCppThis(), (s == null) ? default(HandleRef) : s.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageStencilData_IsA_26(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageStencilData.vtkImageStencilData_IsA_26(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageStencilData_IsTypeOf_27(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageStencilData.vtkImageStencilData_IsTypeOf_27(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageStencilData_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageStencilData NewInstance()
		{
			vtkImageStencilData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageStencilData.vtkImageStencilData_NewInstance_29(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilData_RemoveExtent_30(HandleRef pThis, int r1, int r2, int yIdx, int zIdx);

		public void RemoveExtent(int r1, int r2, int yIdx, int zIdx)
		{
			vtkImageStencilData.vtkImageStencilData_RemoveExtent_30(base.GetCppThis(), r1, r2, yIdx, zIdx);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilData_Replace_31(HandleRef pThis, HandleRef arg0);

		public virtual void Replace(vtkImageStencilData arg0)
		{
			vtkImageStencilData.vtkImageStencilData_Replace_31(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageStencilData_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageStencilData SafeDownCast(vtkObjectBase o)
		{
			vtkImageStencilData vtkImageStencilData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageStencilData.vtkImageStencilData_SafeDownCast_32((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageStencilData = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageStencilData.Register(null);
				}
			}
			return vtkImageStencilData;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilData_SetExtent_33(HandleRef pThis, IntPtr extent);

		public void SetExtent(IntPtr extent)
		{
			vtkImageStencilData.vtkImageStencilData_SetExtent_33(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilData_SetExtent_34(HandleRef pThis, int x1, int x2, int y1, int y2, int z1, int z2);

		public void SetExtent(int x1, int x2, int y1, int y2, int z1, int z2)
		{
			vtkImageStencilData.vtkImageStencilData_SetExtent_34(base.GetCppThis(), x1, x2, y1, y2, z1, z2);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilData_SetOrigin_35(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkImageStencilData.vtkImageStencilData_SetOrigin_35(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilData_SetOrigin_36(HandleRef pThis, IntPtr _arg);

		public virtual void SetOrigin(IntPtr _arg)
		{
			vtkImageStencilData.vtkImageStencilData_SetOrigin_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilData_SetSpacing_37(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetSpacing(double _arg1, double _arg2, double _arg3)
		{
			vtkImageStencilData.vtkImageStencilData_SetSpacing_37(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilData_SetSpacing_38(HandleRef pThis, IntPtr _arg);

		public virtual void SetSpacing(IntPtr _arg)
		{
			vtkImageStencilData.vtkImageStencilData_SetSpacing_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilData_ShallowCopy_39(HandleRef pThis, HandleRef f);

		public override void ShallowCopy(vtkDataObject f)
		{
			vtkImageStencilData.vtkImageStencilData_ShallowCopy_39(base.GetCppThis(), (f == null) ? default(HandleRef) : f.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilData_Subtract_40(HandleRef pThis, HandleRef arg0);

		public virtual void Subtract(vtkImageStencilData arg0)
		{
			vtkImageStencilData.vtkImageStencilData_Subtract_40(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}

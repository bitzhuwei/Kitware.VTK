using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkHAVSVolumeMapper : vtkUnstructuredGridVolumeMapper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHAVSVolumeMapper";

		public new static readonly string MRClassNameKey;

		static vtkHAVSVolumeMapper()
		{
			vtkHAVSVolumeMapper.MRClassNameKey = "class vtkHAVSVolumeMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHAVSVolumeMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHAVSVolumeMapper"));
		}

		public vtkHAVSVolumeMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkHAVSVolumeMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHAVSVolumeMapper New()
		{
			vtkHAVSVolumeMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHAVSVolumeMapper.vtkHAVSVolumeMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHAVSVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkHAVSVolumeMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkHAVSVolumeMapper.vtkHAVSVolumeMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern byte vtkHAVSVolumeMapper_GetGPUDataStructures_01(HandleRef pThis);

		public virtual bool GetGPUDataStructures()
		{
			return vtkHAVSVolumeMapper.vtkHAVSVolumeMapper_GetGPUDataStructures_01(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkHAVSVolumeMapper_GetKBufferSize_02(HandleRef pThis);

		public virtual int GetKBufferSize()
		{
			return vtkHAVSVolumeMapper.vtkHAVSVolumeMapper_GetKBufferSize_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern byte vtkHAVSVolumeMapper_GetLevelOfDetail_03(HandleRef pThis);

		public virtual bool GetLevelOfDetail()
		{
			return vtkHAVSVolumeMapper.vtkHAVSVolumeMapper_GetLevelOfDetail_03(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkHAVSVolumeMapper_GetLevelOfDetailMethod_04(HandleRef pThis);

		public virtual int GetLevelOfDetailMethod()
		{
			return vtkHAVSVolumeMapper.vtkHAVSVolumeMapper_GetLevelOfDetailMethod_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkHAVSVolumeMapper_GetLevelOfDetailTargetTime_05(HandleRef pThis);

		public virtual float GetLevelOfDetailTargetTime()
		{
			return vtkHAVSVolumeMapper.vtkHAVSVolumeMapper_GetLevelOfDetailTargetTime_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern byte vtkHAVSVolumeMapper_GetPartiallyRemoveNonConvexities_06(HandleRef pThis);

		public virtual bool GetPartiallyRemoveNonConvexities()
		{
			return vtkHAVSVolumeMapper.vtkHAVSVolumeMapper_GetPartiallyRemoveNonConvexities_06(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkHAVSVolumeMapper_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHAVSVolumeMapper.vtkHAVSVolumeMapper_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkHAVSVolumeMapper_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHAVSVolumeMapper.vtkHAVSVolumeMapper_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkHAVSVolumeMapper_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHAVSVolumeMapper NewInstance()
		{
			vtkHAVSVolumeMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHAVSVolumeMapper.vtkHAVSVolumeMapper_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHAVSVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkHAVSVolumeMapper_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHAVSVolumeMapper SafeDownCast(vtkObjectBase o)
		{
			vtkHAVSVolumeMapper vtkHAVSVolumeMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHAVSVolumeMapper.vtkHAVSVolumeMapper_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHAVSVolumeMapper = (vtkHAVSVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHAVSVolumeMapper.Register(null);
				}
			}
			return vtkHAVSVolumeMapper;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkHAVSVolumeMapper_SetGPUDataStructures_12(HandleRef pThis, byte arg0);

		public virtual void SetGPUDataStructures(bool arg0)
		{
			vtkHAVSVolumeMapper.vtkHAVSVolumeMapper_SetGPUDataStructures_12(base.GetCppThis(), arg0 ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkHAVSVolumeMapper_SetKBufferSize_13(HandleRef pThis, int _arg);

		public virtual void SetKBufferSize(int _arg)
		{
			vtkHAVSVolumeMapper.vtkHAVSVolumeMapper_SetKBufferSize_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkHAVSVolumeMapper_SetKBufferSizeTo2_14(HandleRef pThis);

		public void SetKBufferSizeTo2()
		{
			vtkHAVSVolumeMapper.vtkHAVSVolumeMapper_SetKBufferSizeTo2_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkHAVSVolumeMapper_SetKBufferSizeTo6_15(HandleRef pThis);

		public void SetKBufferSizeTo6()
		{
			vtkHAVSVolumeMapper.vtkHAVSVolumeMapper_SetKBufferSizeTo6_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkHAVSVolumeMapper_SetLevelOfDetail_16(HandleRef pThis, byte _arg);

		public virtual void SetLevelOfDetail(bool _arg)
		{
			vtkHAVSVolumeMapper.vtkHAVSVolumeMapper_SetLevelOfDetail_16(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkHAVSVolumeMapper_SetLevelOfDetailMethod_17(HandleRef pThis, int arg0);

		public void SetLevelOfDetailMethod(int arg0)
		{
			vtkHAVSVolumeMapper.vtkHAVSVolumeMapper_SetLevelOfDetailMethod_17(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkHAVSVolumeMapper_SetLevelOfDetailMethodArea_18(HandleRef pThis);

		public void SetLevelOfDetailMethodArea()
		{
			vtkHAVSVolumeMapper.vtkHAVSVolumeMapper_SetLevelOfDetailMethodArea_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkHAVSVolumeMapper_SetLevelOfDetailMethodField_19(HandleRef pThis);

		public void SetLevelOfDetailMethodField()
		{
			vtkHAVSVolumeMapper.vtkHAVSVolumeMapper_SetLevelOfDetailMethodField_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkHAVSVolumeMapper_SetLevelOfDetailTargetTime_20(HandleRef pThis, float _arg);

		public virtual void SetLevelOfDetailTargetTime(float _arg)
		{
			vtkHAVSVolumeMapper.vtkHAVSVolumeMapper_SetLevelOfDetailTargetTime_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkHAVSVolumeMapper_SetPartiallyRemoveNonConvexities_21(HandleRef pThis, byte _arg);

		public virtual void SetPartiallyRemoveNonConvexities(bool _arg)
		{
			vtkHAVSVolumeMapper.vtkHAVSVolumeMapper_SetPartiallyRemoveNonConvexities_21(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern byte vtkHAVSVolumeMapper_SupportedByHardware_22(HandleRef pThis, HandleRef arg0);

		public virtual bool SupportedByHardware(vtkRenderer arg0)
		{
			return vtkHAVSVolumeMapper.vtkHAVSVolumeMapper_SupportedByHardware_22(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis()) != 0;
		}
	}
}

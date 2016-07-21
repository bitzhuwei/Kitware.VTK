using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExodusIIWriter : vtkWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExodusIIWriter";

		public new static readonly string MRClassNameKey;

		static vtkExodusIIWriter()
		{
			vtkExodusIIWriter.MRClassNameKey = "class vtkExodusIIWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExodusIIWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExodusIIWriter"));
		}

		public vtkExodusIIWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExodusIIWriter New()
		{
			vtkExodusIIWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExodusIIWriter.vtkExodusIIWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExodusIIWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExodusIIWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExodusIIWriter.vtkExodusIIWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIWriter_GetBlockIdArrayName_01(HandleRef pThis);

		public virtual string GetBlockIdArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIWriter.vtkExodusIIWriter_GetBlockIdArrayName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIWriter_GetFileName_02(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkExodusIIWriter.vtkExodusIIWriter_GetFileName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkExodusIIWriter_GetGhostLevel_03(HandleRef pThis);

		public virtual int GetGhostLevel()
		{
			return vtkExodusIIWriter.vtkExodusIIWriter_GetGhostLevel_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIWriter_GetModelMetadata_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkModelMetadata GetModelMetadata()
		{
			vtkModelMetadata vtkModelMetadata = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExodusIIWriter.vtkExodusIIWriter_GetModelMetadata_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkModelMetadata = (vtkModelMetadata)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkModelMetadata.Register(null);
				}
			}
			return vtkModelMetadata;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkExodusIIWriter_GetStoreDoubles_05(HandleRef pThis);

		public virtual int GetStoreDoubles()
		{
			return vtkExodusIIWriter.vtkExodusIIWriter_GetStoreDoubles_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkExodusIIWriter_GetWriteAllTimeSteps_06(HandleRef pThis);

		public virtual int GetWriteAllTimeSteps()
		{
			return vtkExodusIIWriter.vtkExodusIIWriter_GetWriteAllTimeSteps_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkExodusIIWriter_GetWriteOutBlockIdArray_07(HandleRef pThis);

		public virtual int GetWriteOutBlockIdArray()
		{
			return vtkExodusIIWriter.vtkExodusIIWriter_GetWriteOutBlockIdArray_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkExodusIIWriter_GetWriteOutGlobalElementIdArray_08(HandleRef pThis);

		public virtual int GetWriteOutGlobalElementIdArray()
		{
			return vtkExodusIIWriter.vtkExodusIIWriter_GetWriteOutGlobalElementIdArray_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkExodusIIWriter_GetWriteOutGlobalNodeIdArray_09(HandleRef pThis);

		public virtual int GetWriteOutGlobalNodeIdArray()
		{
			return vtkExodusIIWriter.vtkExodusIIWriter_GetWriteOutGlobalNodeIdArray_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkExodusIIWriter_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExodusIIWriter.vtkExodusIIWriter_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkExodusIIWriter_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExodusIIWriter.vtkExodusIIWriter_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIWriter_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExodusIIWriter NewInstance()
		{
			vtkExodusIIWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExodusIIWriter.vtkExodusIIWriter_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExodusIIWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusIIWriter_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExodusIIWriter SafeDownCast(vtkObjectBase o)
		{
			vtkExodusIIWriter vtkExodusIIWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExodusIIWriter.vtkExodusIIWriter_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExodusIIWriter = (vtkExodusIIWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExodusIIWriter.Register(null);
				}
			}
			return vtkExodusIIWriter;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExodusIIWriter_SetBlockIdArrayName_15(HandleRef pThis, string _arg);

		public virtual void SetBlockIdArrayName(string _arg)
		{
			vtkExodusIIWriter.vtkExodusIIWriter_SetBlockIdArrayName_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExodusIIWriter_SetFileName_16(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkExodusIIWriter.vtkExodusIIWriter_SetFileName_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExodusIIWriter_SetGhostLevel_17(HandleRef pThis, int _arg);

		public virtual void SetGhostLevel(int _arg)
		{
			vtkExodusIIWriter.vtkExodusIIWriter_SetGhostLevel_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExodusIIWriter_SetModelMetadata_18(HandleRef pThis, HandleRef arg0);

		public void SetModelMetadata(vtkModelMetadata arg0)
		{
			vtkExodusIIWriter.vtkExodusIIWriter_SetModelMetadata_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExodusIIWriter_SetStoreDoubles_19(HandleRef pThis, int _arg);

		public virtual void SetStoreDoubles(int _arg)
		{
			vtkExodusIIWriter.vtkExodusIIWriter_SetStoreDoubles_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExodusIIWriter_SetWriteAllTimeSteps_20(HandleRef pThis, int _arg);

		public virtual void SetWriteAllTimeSteps(int _arg)
		{
			vtkExodusIIWriter.vtkExodusIIWriter_SetWriteAllTimeSteps_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExodusIIWriter_SetWriteOutBlockIdArray_21(HandleRef pThis, int _arg);

		public virtual void SetWriteOutBlockIdArray(int _arg)
		{
			vtkExodusIIWriter.vtkExodusIIWriter_SetWriteOutBlockIdArray_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExodusIIWriter_SetWriteOutGlobalElementIdArray_22(HandleRef pThis, int _arg);

		public virtual void SetWriteOutGlobalElementIdArray(int _arg)
		{
			vtkExodusIIWriter.vtkExodusIIWriter_SetWriteOutGlobalElementIdArray_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExodusIIWriter_SetWriteOutGlobalNodeIdArray_23(HandleRef pThis, int _arg);

		public virtual void SetWriteOutGlobalNodeIdArray(int _arg)
		{
			vtkExodusIIWriter.vtkExodusIIWriter_SetWriteOutGlobalNodeIdArray_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExodusIIWriter_WriteAllTimeStepsOff_24(HandleRef pThis);

		public virtual void WriteAllTimeStepsOff()
		{
			vtkExodusIIWriter.vtkExodusIIWriter_WriteAllTimeStepsOff_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExodusIIWriter_WriteAllTimeStepsOn_25(HandleRef pThis);

		public virtual void WriteAllTimeStepsOn()
		{
			vtkExodusIIWriter.vtkExodusIIWriter_WriteAllTimeStepsOn_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExodusIIWriter_WriteOutBlockIdArrayOff_26(HandleRef pThis);

		public virtual void WriteOutBlockIdArrayOff()
		{
			vtkExodusIIWriter.vtkExodusIIWriter_WriteOutBlockIdArrayOff_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExodusIIWriter_WriteOutBlockIdArrayOn_27(HandleRef pThis);

		public virtual void WriteOutBlockIdArrayOn()
		{
			vtkExodusIIWriter.vtkExodusIIWriter_WriteOutBlockIdArrayOn_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExodusIIWriter_WriteOutGlobalElementIdArrayOff_28(HandleRef pThis);

		public virtual void WriteOutGlobalElementIdArrayOff()
		{
			vtkExodusIIWriter.vtkExodusIIWriter_WriteOutGlobalElementIdArrayOff_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExodusIIWriter_WriteOutGlobalElementIdArrayOn_29(HandleRef pThis);

		public virtual void WriteOutGlobalElementIdArrayOn()
		{
			vtkExodusIIWriter.vtkExodusIIWriter_WriteOutGlobalElementIdArrayOn_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExodusIIWriter_WriteOutGlobalNodeIdArrayOff_30(HandleRef pThis);

		public virtual void WriteOutGlobalNodeIdArrayOff()
		{
			vtkExodusIIWriter.vtkExodusIIWriter_WriteOutGlobalNodeIdArrayOff_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkExodusIIWriter_WriteOutGlobalNodeIdArrayOn_31(HandleRef pThis);

		public virtual void WriteOutGlobalNodeIdArrayOn()
		{
			vtkExodusIIWriter.vtkExodusIIWriter_WriteOutGlobalNodeIdArrayOn_31(base.GetCppThis());
		}
	}
}

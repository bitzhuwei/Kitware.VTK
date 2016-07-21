using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExodusModel : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExodusModel";

		public new static readonly string MRClassNameKey;

		static vtkExodusModel()
		{
			vtkExodusModel.MRClassNameKey = "class vtkExodusModel";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExodusModel.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExodusModel"));
		}

		public vtkExodusModel(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusModel_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExodusModel New()
		{
			vtkExodusModel result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExodusModel.vtkExodusModel_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExodusModel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExodusModel() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExodusModel.vtkExodusModel_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusModel_AddUGridElementVariable_01(HandleRef pThis, string ugridVarName, string origName, int numComponents);

		public int AddUGridElementVariable(string ugridVarName, string origName, int numComponents)
		{
			return vtkExodusModel.vtkExodusModel_AddUGridElementVariable_01(base.GetCppThis(), ugridVarName, origName, numComponents);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusModel_AddUGridNodeVariable_02(HandleRef pThis, string ugridVarName, string origName, int numComponents);

		public int AddUGridNodeVariable(string ugridVarName, string origName, int numComponents)
		{
			return vtkExodusModel.vtkExodusModel_AddUGridNodeVariable_02(base.GetCppThis(), ugridVarName, origName, numComponents);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusModel_ExtractExodusModel_03(HandleRef pThis, HandleRef globalCellIdList, HandleRef grid, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkExodusModel ExtractExodusModel(vtkIdTypeArray globalCellIdList, vtkUnstructuredGrid grid)
		{
			vtkExodusModel vtkExodusModel = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExodusModel.vtkExodusModel_ExtractExodusModel_03(base.GetCppThis(), (globalCellIdList == null) ? default(HandleRef) : globalCellIdList.GetCppThis(), (grid == null) ? default(HandleRef) : grid.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExodusModel = (vtkExodusModel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExodusModel.Register(null);
				}
			}
			return vtkExodusModel;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusModel_GetModelMetadata_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkModelMetadata GetModelMetadata()
		{
			vtkModelMetadata vtkModelMetadata = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExodusModel.vtkExodusModel_GetModelMetadata_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusModel_HasMetadata_05(HandleRef grid);

		public static int HasMetadata(vtkUnstructuredGrid grid)
		{
			return vtkExodusModel.vtkExodusModel_HasMetadata_05((grid == null) ? default(HandleRef) : grid.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusModel_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExodusModel.vtkExodusModel_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusModel_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExodusModel.vtkExodusModel_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusModel_MergeExodusModel_08(HandleRef pThis, HandleRef em);

		public int MergeExodusModel(vtkExodusModel em)
		{
			return vtkExodusModel.vtkExodusModel_MergeExodusModel_08(base.GetCppThis(), (em == null) ? default(HandleRef) : em.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusModel_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExodusModel NewInstance()
		{
			vtkExodusModel result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExodusModel.vtkExodusModel_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExodusModel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusModel_PackExodusModel_11(HandleRef pThis, HandleRef grid);

		public void PackExodusModel(vtkUnstructuredGrid grid)
		{
			vtkExodusModel.vtkExodusModel_PackExodusModel_11(base.GetCppThis(), (grid == null) ? default(HandleRef) : grid.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusModel_RemoveUGridElementVariable_12(HandleRef pThis, string ugridVarName);

		public int RemoveUGridElementVariable(string ugridVarName)
		{
			return vtkExodusModel.vtkExodusModel_RemoveUGridElementVariable_12(base.GetCppThis(), ugridVarName);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusModel_RemoveUGridNodeVariable_13(HandleRef pThis, string ugridVarName);

		public int RemoveUGridNodeVariable(string ugridVarName)
		{
			return vtkExodusModel.vtkExodusModel_RemoveUGridNodeVariable_13(base.GetCppThis(), ugridVarName);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusModel_Reset_14(HandleRef pThis);

		public void Reset()
		{
			vtkExodusModel.vtkExodusModel_Reset_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkExodusModel_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExodusModel SafeDownCast(vtkObjectBase o)
		{
			vtkExodusModel vtkExodusModel = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExodusModel.vtkExodusModel_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExodusModel = (vtkExodusModel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExodusModel.Register(null);
				}
			}
			return vtkExodusModel;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusModel_SetGlobalInformation_16(HandleRef pThis, int fid, int compute_word_size);

		public int SetGlobalInformation(int fid, int compute_word_size)
		{
			return vtkExodusModel.vtkExodusModel_SetGlobalInformation_16(base.GetCppThis(), fid, compute_word_size);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusModel_SetLocalInformation_17(HandleRef pThis, HandleRef ugrid, int fid, int timeStep, int newGeometry, int compute_word_size);

		public int SetLocalInformation(vtkUnstructuredGrid ugrid, int fid, int timeStep, int newGeometry, int compute_word_size)
		{
			return vtkExodusModel.vtkExodusModel_SetLocalInformation_17(base.GetCppThis(), (ugrid == null) ? default(HandleRef) : ugrid.GetCppThis(), fid, timeStep, newGeometry, compute_word_size);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkExodusModel_SetModelMetadata_18(HandleRef pThis, HandleRef emData);

		public void SetModelMetadata(vtkModelMetadata emData)
		{
			vtkExodusModel.vtkExodusModel_SetModelMetadata_18(base.GetCppThis(), (emData == null) ? default(HandleRef) : emData.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkExodusModel_UnpackExodusModel_19(HandleRef pThis, HandleRef grid, int deleteIt);

		public int UnpackExodusModel(vtkUnstructuredGrid grid, int deleteIt)
		{
			return vtkExodusModel.vtkExodusModel_UnpackExodusModel_19(base.GetCppThis(), (grid == null) ? default(HandleRef) : grid.GetCppThis(), deleteIt);
		}
	}
}

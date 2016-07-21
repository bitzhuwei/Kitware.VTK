using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDataSetAttributes : vtkFieldData
	{
		public enum AttributeCopyOperations
		{
			ALLCOPY = 3,
			COPYTUPLE = 0,
			INTERPOLATE,
			PASSDATA
		}

		public enum AttributeLimitTypes
		{
			EXACT = 1,
			MAX = 0,
			NOLIMIT = 2
		}

		public enum AttributeTypes
		{
			EDGEFLAG = 7,
			GLOBALIDS = 5,
			NORMALS = 2,
			NUM_ATTRIBUTES = 8,
			PEDIGREEIDS = 6,
			SCALARS = 0,
			TCOORDS = 3,
			TENSORS,
			VECTORS = 1
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetAttributes";

		public new static readonly string MRClassNameKey;

		static vtkDataSetAttributes()
		{
			vtkDataSetAttributes.MRClassNameKey = "class vtkDataSetAttributes";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataSetAttributes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetAttributes"));
		}

		public vtkDataSetAttributes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetAttributes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataSetAttributes New()
		{
			vtkDataSetAttributes result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDataSetAttributes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDataSetAttributes.vtkDataSetAttributes_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_CopyAllOff_01(HandleRef pThis, int ctype);

		public override void CopyAllOff(int ctype)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyAllOff_01(base.GetCppThis(), ctype);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_CopyAllOn_02(HandleRef pThis, int ctype);

		public override void CopyAllOn(int ctype)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyAllOn_02(base.GetCppThis(), ctype);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_CopyAllocate_03(HandleRef pThis, HandleRef pd, long sze, long ext);

		public void CopyAllocate(vtkDataSetAttributes pd, long sze, long ext)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyAllocate_03(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis(), sze, ext);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_CopyAllocate_04(HandleRef pThis, HandleRef pd, long sze, long ext, int shallowCopyArrays);

		public void CopyAllocate(vtkDataSetAttributes pd, long sze, long ext, int shallowCopyArrays)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyAllocate_04(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis(), sze, ext, shallowCopyArrays);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_CopyData_05(HandleRef pThis, HandleRef fromPd, long fromId, long toId);

		public void CopyData(vtkDataSetAttributes fromPd, long fromId, long toId)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyData_05(base.GetCppThis(), (fromPd == null) ? default(HandleRef) : fromPd.GetCppThis(), fromId, toId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_CopyGlobalIdsOff_06(HandleRef pThis);

		public virtual void CopyGlobalIdsOff()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyGlobalIdsOff_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_CopyGlobalIdsOn_07(HandleRef pThis);

		public virtual void CopyGlobalIdsOn()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyGlobalIdsOn_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_CopyNormalsOff_08(HandleRef pThis);

		public virtual void CopyNormalsOff()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyNormalsOff_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_CopyNormalsOn_09(HandleRef pThis);

		public virtual void CopyNormalsOn()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyNormalsOn_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_CopyPedigreeIdsOff_10(HandleRef pThis);

		public virtual void CopyPedigreeIdsOff()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyPedigreeIdsOff_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_CopyPedigreeIdsOn_11(HandleRef pThis);

		public virtual void CopyPedigreeIdsOn()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyPedigreeIdsOn_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_CopyScalarsOff_12(HandleRef pThis);

		public virtual void CopyScalarsOff()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyScalarsOff_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_CopyScalarsOn_13(HandleRef pThis);

		public virtual void CopyScalarsOn()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyScalarsOn_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_CopyStructuredData_14(HandleRef pThis, HandleRef inDsa, IntPtr inExt, IntPtr outExt);

		public void CopyStructuredData(vtkDataSetAttributes inDsa, IntPtr inExt, IntPtr outExt)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyStructuredData_14(base.GetCppThis(), (inDsa == null) ? default(HandleRef) : inDsa.GetCppThis(), inExt, outExt);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_CopyTCoordsOff_15(HandleRef pThis);

		public virtual void CopyTCoordsOff()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyTCoordsOff_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_CopyTCoordsOn_16(HandleRef pThis);

		public virtual void CopyTCoordsOn()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyTCoordsOn_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_CopyTensorsOff_17(HandleRef pThis);

		public virtual void CopyTensorsOff()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyTensorsOff_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_CopyTensorsOn_18(HandleRef pThis);

		public virtual void CopyTensorsOn()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyTensorsOn_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_CopyTuple_19(HandleRef pThis, HandleRef fromData, HandleRef toData, long fromId, long toId);

		public void CopyTuple(vtkAbstractArray fromData, vtkAbstractArray toData, long fromId, long toId)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyTuple_19(base.GetCppThis(), (fromData == null) ? default(HandleRef) : fromData.GetCppThis(), (toData == null) ? default(HandleRef) : toData.GetCppThis(), fromId, toId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_CopyVectorsOff_20(HandleRef pThis);

		public virtual void CopyVectorsOff()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyVectorsOff_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_CopyVectorsOn_21(HandleRef pThis);

		public virtual void CopyVectorsOn()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_CopyVectorsOn_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_DeepCopy_22(HandleRef pThis, HandleRef pd);

		public override void DeepCopy(vtkFieldData pd)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_DeepCopy_22(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetAttributes_GetAbstractAttribute_23(HandleRef pThis, int attributeType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAbstractArray GetAbstractAttribute(int attributeType)
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetAbstractAttribute_23(base.GetCppThis(), attributeType, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetAttributes_GetAttribute_24(HandleRef pThis, int attributeType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataArray GetAttribute(int attributeType)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetAttribute_24(base.GetCppThis(), attributeType, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_GetAttributeIndices_25(HandleRef pThis, IntPtr indexArray);

		public void GetAttributeIndices(IntPtr indexArray)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_GetAttributeIndices_25(base.GetCppThis(), indexArray);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetAttributes_GetAttributeTypeAsString_26(int attributeType);

		public static string GetAttributeTypeAsString(int attributeType)
		{
			return Marshal.PtrToStringAnsi(vtkDataSetAttributes.vtkDataSetAttributes_GetAttributeTypeAsString_26(attributeType));
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetAttributes_GetCopyGlobalIds_27(HandleRef pThis, int ctype);

		public int GetCopyGlobalIds(int ctype)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_GetCopyGlobalIds_27(base.GetCppThis(), ctype);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetAttributes_GetCopyNormals_28(HandleRef pThis, int ctype);

		public int GetCopyNormals(int ctype)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_GetCopyNormals_28(base.GetCppThis(), ctype);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetAttributes_GetCopyPedigreeIds_29(HandleRef pThis, int ctype);

		public int GetCopyPedigreeIds(int ctype)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_GetCopyPedigreeIds_29(base.GetCppThis(), ctype);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetAttributes_GetCopyScalars_30(HandleRef pThis, int ctype);

		public int GetCopyScalars(int ctype)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_GetCopyScalars_30(base.GetCppThis(), ctype);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetAttributes_GetCopyTCoords_31(HandleRef pThis, int ctype);

		public int GetCopyTCoords(int ctype)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_GetCopyTCoords_31(base.GetCppThis(), ctype);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetAttributes_GetCopyTensors_32(HandleRef pThis, int ctype);

		public int GetCopyTensors(int ctype)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_GetCopyTensors_32(base.GetCppThis(), ctype);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetAttributes_GetCopyVectors_33(HandleRef pThis, int ctype);

		public int GetCopyVectors(int ctype)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_GetCopyVectors_33(base.GetCppThis(), ctype);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetAttributes_GetGlobalIds_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataArray GetGlobalIds()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetGlobalIds_34(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetAttributes_GetGlobalIds_35(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataArray GetGlobalIds(string name)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetGlobalIds_35(base.GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetAttributes_GetLongAttributeTypeAsString_36(int attributeType);

		public static string GetLongAttributeTypeAsString(int attributeType)
		{
			return Marshal.PtrToStringAnsi(vtkDataSetAttributes.vtkDataSetAttributes_GetLongAttributeTypeAsString_36(attributeType));
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetAttributes_GetNormals_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataArray GetNormals()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetNormals_37(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetAttributes_GetNormals_38(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataArray GetNormals(string name)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetNormals_38(base.GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetAttributes_GetPedigreeIds_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAbstractArray GetPedigreeIds()
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetPedigreeIds_39(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetAttributes_GetPedigreeIds_40(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAbstractArray GetPedigreeIds(string name)
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetPedigreeIds_40(base.GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetAttributes_GetScalars_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataArray GetScalars()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetScalars_41(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetAttributes_GetScalars_42(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataArray GetScalars(string name)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetScalars_42(base.GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetAttributes_GetTCoords_43(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataArray GetTCoords()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetTCoords_43(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetAttributes_GetTCoords_44(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataArray GetTCoords(string name)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetTCoords_44(base.GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetAttributes_GetTensors_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataArray GetTensors()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetTensors_45(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetAttributes_GetTensors_46(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataArray GetTensors(string name)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetTensors_46(base.GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetAttributes_GetVectors_47(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataArray GetVectors()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetVectors_47(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetAttributes_GetVectors_48(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataArray GetVectors(string name)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_GetVectors_48(base.GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_Initialize_49(HandleRef pThis);

		public override void Initialize()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_Initialize_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_InterpolateAllocate_50(HandleRef pThis, HandleRef pd, long sze, long ext);

		public void InterpolateAllocate(vtkDataSetAttributes pd, long sze, long ext)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_InterpolateAllocate_50(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis(), sze, ext);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_InterpolateAllocate_51(HandleRef pThis, HandleRef pd, long sze, long ext, int shallowCopyArrays);

		public void InterpolateAllocate(vtkDataSetAttributes pd, long sze, long ext, int shallowCopyArrays)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_InterpolateAllocate_51(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis(), sze, ext, shallowCopyArrays);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_InterpolateEdge_52(HandleRef pThis, HandleRef fromPd, long toId, long p1, long p2, double t);

		public void InterpolateEdge(vtkDataSetAttributes fromPd, long toId, long p1, long p2, double t)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_InterpolateEdge_52(base.GetCppThis(), (fromPd == null) ? default(HandleRef) : fromPd.GetCppThis(), toId, p1, p2, t);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_InterpolatePoint_53(HandleRef pThis, HandleRef fromPd, long toId, HandleRef ids, IntPtr weights);

		public void InterpolatePoint(vtkDataSetAttributes fromPd, long toId, vtkIdList ids, IntPtr weights)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_InterpolatePoint_53(base.GetCppThis(), (fromPd == null) ? default(HandleRef) : fromPd.GetCppThis(), toId, (ids == null) ? default(HandleRef) : ids.GetCppThis(), weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_InterpolateTime_54(HandleRef pThis, HandleRef from1, HandleRef from2, long id, double t);

		public void InterpolateTime(vtkDataSetAttributes from1, vtkDataSetAttributes from2, long id, double t)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_InterpolateTime_54(base.GetCppThis(), (from1 == null) ? default(HandleRef) : from1.GetCppThis(), (from2 == null) ? default(HandleRef) : from2.GetCppThis(), id, t);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetAttributes_IsA_55(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_IsA_55(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetAttributes_IsArrayAnAttribute_56(HandleRef pThis, int idx);

		public int IsArrayAnAttribute(int idx)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_IsArrayAnAttribute_56(base.GetCppThis(), idx);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetAttributes_IsTypeOf_57(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_IsTypeOf_57(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetAttributes_NewInstance_59(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataSetAttributes NewInstance()
		{
			vtkDataSetAttributes result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_NewInstance_59(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_PassData_60(HandleRef pThis, HandleRef fd);

		public override void PassData(vtkFieldData fd)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_PassData_60(base.GetCppThis(), (fd == null) ? default(HandleRef) : fd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_RemoveArray_61(HandleRef pThis, string name);

		public override void RemoveArray(string name)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_RemoveArray_61(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_RemoveArray_62(HandleRef pThis, int index);

		public virtual void RemoveArray(int index)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_RemoveArray_62(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetAttributes_SafeDownCast_63(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataSetAttributes SafeDownCast(vtkObjectBase o)
		{
			vtkDataSetAttributes vtkDataSetAttributes = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetAttributes.vtkDataSetAttributes_SafeDownCast_63((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetAttributes = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetAttributes.Register(null);
				}
			}
			return vtkDataSetAttributes;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetAttributes_SetActiveAttribute_64(HandleRef pThis, string name, int attributeType);

		public int SetActiveAttribute(string name, int attributeType)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetActiveAttribute_64(base.GetCppThis(), name, attributeType);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetAttributes_SetActiveAttribute_65(HandleRef pThis, int index, int attributeType);

		public int SetActiveAttribute(int index, int attributeType)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetActiveAttribute_65(base.GetCppThis(), index, attributeType);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetAttributes_SetActiveGlobalIds_66(HandleRef pThis, string name);

		public int SetActiveGlobalIds(string name)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetActiveGlobalIds_66(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetAttributes_SetActiveNormals_67(HandleRef pThis, string name);

		public int SetActiveNormals(string name)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetActiveNormals_67(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetAttributes_SetActivePedigreeIds_68(HandleRef pThis, string name);

		public int SetActivePedigreeIds(string name)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetActivePedigreeIds_68(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetAttributes_SetActiveScalars_69(HandleRef pThis, string name);

		public int SetActiveScalars(string name)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetActiveScalars_69(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetAttributes_SetActiveTCoords_70(HandleRef pThis, string name);

		public int SetActiveTCoords(string name)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetActiveTCoords_70(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetAttributes_SetActiveTensors_71(HandleRef pThis, string name);

		public int SetActiveTensors(string name)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetActiveTensors_71(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetAttributes_SetActiveVectors_72(HandleRef pThis, string name);

		public int SetActiveVectors(string name)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetActiveVectors_72(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_SetCopyAttribute_73(HandleRef pThis, int index, int value, int ctype);

		public void SetCopyAttribute(int index, int value, int ctype)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_SetCopyAttribute_73(base.GetCppThis(), index, value, ctype);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_SetCopyGlobalIds_74(HandleRef pThis, int i, int ctype);

		public void SetCopyGlobalIds(int i, int ctype)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_SetCopyGlobalIds_74(base.GetCppThis(), i, ctype);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_SetCopyNormals_75(HandleRef pThis, int i, int ctype);

		public void SetCopyNormals(int i, int ctype)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_SetCopyNormals_75(base.GetCppThis(), i, ctype);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_SetCopyPedigreeIds_76(HandleRef pThis, int i, int ctype);

		public void SetCopyPedigreeIds(int i, int ctype)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_SetCopyPedigreeIds_76(base.GetCppThis(), i, ctype);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_SetCopyScalars_77(HandleRef pThis, int i, int ctype);

		public void SetCopyScalars(int i, int ctype)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_SetCopyScalars_77(base.GetCppThis(), i, ctype);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_SetCopyTCoords_78(HandleRef pThis, int i, int ctype);

		public void SetCopyTCoords(int i, int ctype)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_SetCopyTCoords_78(base.GetCppThis(), i, ctype);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_SetCopyTensors_79(HandleRef pThis, int i, int ctype);

		public void SetCopyTensors(int i, int ctype)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_SetCopyTensors_79(base.GetCppThis(), i, ctype);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_SetCopyVectors_80(HandleRef pThis, int i, int ctype);

		public void SetCopyVectors(int i, int ctype)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_SetCopyVectors_80(base.GetCppThis(), i, ctype);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetAttributes_SetGlobalIds_81(HandleRef pThis, HandleRef da);

		public int SetGlobalIds(vtkDataArray da)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetGlobalIds_81(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetAttributes_SetNormals_82(HandleRef pThis, HandleRef da);

		public int SetNormals(vtkDataArray da)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetNormals_82(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetAttributes_SetPedigreeIds_83(HandleRef pThis, HandleRef da);

		public int SetPedigreeIds(vtkAbstractArray da)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetPedigreeIds_83(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetAttributes_SetScalars_84(HandleRef pThis, HandleRef da);

		public int SetScalars(vtkDataArray da)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetScalars_84(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetAttributes_SetTCoords_85(HandleRef pThis, HandleRef da);

		public int SetTCoords(vtkDataArray da)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetTCoords_85(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetAttributes_SetTensors_86(HandleRef pThis, HandleRef da);

		public int SetTensors(vtkDataArray da)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetTensors_86(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetAttributes_SetVectors_87(HandleRef pThis, HandleRef da);

		public int SetVectors(vtkDataArray da)
		{
			return vtkDataSetAttributes.vtkDataSetAttributes_SetVectors_87(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_ShallowCopy_88(HandleRef pThis, HandleRef pd);

		public override void ShallowCopy(vtkFieldData pd)
		{
			vtkDataSetAttributes.vtkDataSetAttributes_ShallowCopy_88(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetAttributes_Update_89(HandleRef pThis);

		public virtual void Update()
		{
			vtkDataSetAttributes.vtkDataSetAttributes_Update_89(base.GetCppThis());
		}
	}
}

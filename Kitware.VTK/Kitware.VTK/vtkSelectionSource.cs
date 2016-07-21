using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSelectionSource : vtkSelectionAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSelectionSource";

		public new static readonly string MRClassNameKey;

		static vtkSelectionSource()
		{
			vtkSelectionSource.MRClassNameKey = "class vtkSelectionSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSelectionSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSelectionSource"));
		}

		public vtkSelectionSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSelectionSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSelectionSource New()
		{
			vtkSelectionSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSelectionSource.vtkSelectionSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSelectionSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSelectionSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSelectionSource.vtkSelectionSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectionSource_AddBlock_01(HandleRef pThis, long blockno);

		public void AddBlock(long blockno)
		{
			vtkSelectionSource.vtkSelectionSource_AddBlock_01(base.GetCppThis(), blockno);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectionSource_AddID_02(HandleRef pThis, long piece, long id);

		public void AddID(long piece, long id)
		{
			vtkSelectionSource.vtkSelectionSource_AddID_02(base.GetCppThis(), piece, id);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectionSource_AddLocation_03(HandleRef pThis, double x, double y, double z);

		public void AddLocation(double x, double y, double z)
		{
			vtkSelectionSource.vtkSelectionSource_AddLocation_03(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectionSource_AddStringID_04(HandleRef pThis, long piece, string id);

		public void AddStringID(long piece, string id)
		{
			vtkSelectionSource.vtkSelectionSource_AddStringID_04(base.GetCppThis(), piece, id);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectionSource_AddThreshold_05(HandleRef pThis, double min, double max);

		public void AddThreshold(double min, double max)
		{
			vtkSelectionSource.vtkSelectionSource_AddThreshold_05(base.GetCppThis(), min, max);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSelectionSource_GetArrayComponent_06(HandleRef pThis);

		public virtual int GetArrayComponent()
		{
			return vtkSelectionSource.vtkSelectionSource_GetArrayComponent_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSelectionSource_GetArrayName_07(HandleRef pThis);

		public virtual string GetArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkSelectionSource.vtkSelectionSource_GetArrayName_07(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSelectionSource_GetCompositeIndex_08(HandleRef pThis);

		public virtual int GetCompositeIndex()
		{
			return vtkSelectionSource.vtkSelectionSource_GetCompositeIndex_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSelectionSource_GetContainingCells_09(HandleRef pThis);

		public virtual int GetContainingCells()
		{
			return vtkSelectionSource.vtkSelectionSource_GetContainingCells_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSelectionSource_GetContentType_10(HandleRef pThis);

		public virtual int GetContentType()
		{
			return vtkSelectionSource.vtkSelectionSource_GetContentType_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSelectionSource_GetFieldType_11(HandleRef pThis);

		public virtual int GetFieldType()
		{
			return vtkSelectionSource.vtkSelectionSource_GetFieldType_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSelectionSource_GetHierarchicalIndex_12(HandleRef pThis);

		public virtual int GetHierarchicalIndex()
		{
			return vtkSelectionSource.vtkSelectionSource_GetHierarchicalIndex_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSelectionSource_GetHierarchicalLevel_13(HandleRef pThis);

		public virtual int GetHierarchicalLevel()
		{
			return vtkSelectionSource.vtkSelectionSource_GetHierarchicalLevel_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSelectionSource_GetInverse_14(HandleRef pThis);

		public virtual int GetInverse()
		{
			return vtkSelectionSource.vtkSelectionSource_GetInverse_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSelectionSource_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSelectionSource.vtkSelectionSource_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSelectionSource_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSelectionSource.vtkSelectionSource_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSelectionSource_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSelectionSource NewInstance()
		{
			vtkSelectionSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSelectionSource.vtkSelectionSource_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSelectionSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectionSource_RemoveAllBlocks_19(HandleRef pThis);

		public void RemoveAllBlocks()
		{
			vtkSelectionSource.vtkSelectionSource_RemoveAllBlocks_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectionSource_RemoveAllIDs_20(HandleRef pThis);

		public void RemoveAllIDs()
		{
			vtkSelectionSource.vtkSelectionSource_RemoveAllIDs_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectionSource_RemoveAllLocations_21(HandleRef pThis);

		public void RemoveAllLocations()
		{
			vtkSelectionSource.vtkSelectionSource_RemoveAllLocations_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectionSource_RemoveAllStringIDs_22(HandleRef pThis);

		public void RemoveAllStringIDs()
		{
			vtkSelectionSource.vtkSelectionSource_RemoveAllStringIDs_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectionSource_RemoveAllThresholds_23(HandleRef pThis);

		public void RemoveAllThresholds()
		{
			vtkSelectionSource.vtkSelectionSource_RemoveAllThresholds_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSelectionSource_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSelectionSource SafeDownCast(vtkObjectBase o)
		{
			vtkSelectionSource vtkSelectionSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSelectionSource.vtkSelectionSource_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelectionSource = (vtkSelectionSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelectionSource.Register(null);
				}
			}
			return vtkSelectionSource;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectionSource_SetArrayComponent_25(HandleRef pThis, int _arg);

		public virtual void SetArrayComponent(int _arg)
		{
			vtkSelectionSource.vtkSelectionSource_SetArrayComponent_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectionSource_SetArrayName_26(HandleRef pThis, string _arg);

		public virtual void SetArrayName(string _arg)
		{
			vtkSelectionSource.vtkSelectionSource_SetArrayName_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectionSource_SetCompositeIndex_27(HandleRef pThis, int _arg);

		public virtual void SetCompositeIndex(int _arg)
		{
			vtkSelectionSource.vtkSelectionSource_SetCompositeIndex_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectionSource_SetContainingCells_28(HandleRef pThis, int _arg);

		public virtual void SetContainingCells(int _arg)
		{
			vtkSelectionSource.vtkSelectionSource_SetContainingCells_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectionSource_SetContentType_29(HandleRef pThis, int _arg);

		public virtual void SetContentType(int _arg)
		{
			vtkSelectionSource.vtkSelectionSource_SetContentType_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectionSource_SetFieldType_30(HandleRef pThis, int _arg);

		public virtual void SetFieldType(int _arg)
		{
			vtkSelectionSource.vtkSelectionSource_SetFieldType_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectionSource_SetFrustum_31(HandleRef pThis, IntPtr vertices);

		public void SetFrustum(IntPtr vertices)
		{
			vtkSelectionSource.vtkSelectionSource_SetFrustum_31(base.GetCppThis(), vertices);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectionSource_SetHierarchicalIndex_32(HandleRef pThis, int _arg);

		public virtual void SetHierarchicalIndex(int _arg)
		{
			vtkSelectionSource.vtkSelectionSource_SetHierarchicalIndex_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectionSource_SetHierarchicalLevel_33(HandleRef pThis, int _arg);

		public virtual void SetHierarchicalLevel(int _arg)
		{
			vtkSelectionSource.vtkSelectionSource_SetHierarchicalLevel_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectionSource_SetInverse_34(HandleRef pThis, int _arg);

		public virtual void SetInverse(int _arg)
		{
			vtkSelectionSource.vtkSelectionSource_SetInverse_34(base.GetCppThis(), _arg);
		}
	}
}

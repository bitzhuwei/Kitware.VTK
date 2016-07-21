using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAnnotationLink : vtkAnnotationLayersAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAnnotationLink";

		public new static readonly string MRClassNameKey;

		static vtkAnnotationLink()
		{
			vtkAnnotationLink.MRClassNameKey = "class vtkAnnotationLink";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAnnotationLink.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAnnotationLink"));
		}

		public vtkAnnotationLink(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotationLink_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAnnotationLink New()
		{
			vtkAnnotationLink result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnnotationLink.vtkAnnotationLink_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAnnotationLink)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAnnotationLink() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAnnotationLink.vtkAnnotationLink_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAnnotationLink_AddDomainMap_01(HandleRef pThis, HandleRef map);

		public void AddDomainMap(vtkTable map)
		{
			vtkAnnotationLink.vtkAnnotationLink_AddDomainMap_01(base.GetCppThis(), (map == null) ? default(HandleRef) : map.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotationLink_GetAnnotationLayers_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAnnotationLayers GetAnnotationLayers()
		{
			vtkAnnotationLayers vtkAnnotationLayers = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnnotationLink.vtkAnnotationLink_GetAnnotationLayers_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnnotationLayers = (vtkAnnotationLayers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnnotationLayers.Register(null);
				}
			}
			return vtkAnnotationLayers;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotationLink_GetCurrentSelection_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkSelection GetCurrentSelection()
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnnotationLink.vtkAnnotationLink_GetCurrentSelection_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotationLink_GetDomainMap_04(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkTable GetDomainMap(int i)
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnnotationLink.vtkAnnotationLink_GetDomainMap_04(base.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkAnnotationLink_GetMTime_05(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkAnnotationLink.vtkAnnotationLink_GetMTime_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkAnnotationLink_GetNumberOfDomainMaps_06(HandleRef pThis);

		public int GetNumberOfDomainMaps()
		{
			return vtkAnnotationLink.vtkAnnotationLink_GetNumberOfDomainMaps_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkAnnotationLink_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAnnotationLink.vtkAnnotationLink_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkAnnotationLink_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAnnotationLink.vtkAnnotationLink_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotationLink_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAnnotationLink NewInstance()
		{
			vtkAnnotationLink result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnnotationLink.vtkAnnotationLink_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAnnotationLink)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAnnotationLink_RemoveAllDomainMaps_11(HandleRef pThis);

		public void RemoveAllDomainMaps()
		{
			vtkAnnotationLink.vtkAnnotationLink_RemoveAllDomainMaps_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAnnotationLink_RemoveDomainMap_12(HandleRef pThis, HandleRef map);

		public void RemoveDomainMap(vtkTable map)
		{
			vtkAnnotationLink.vtkAnnotationLink_RemoveDomainMap_12(base.GetCppThis(), (map == null) ? default(HandleRef) : map.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAnnotationLink_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAnnotationLink SafeDownCast(vtkObjectBase o)
		{
			vtkAnnotationLink vtkAnnotationLink = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAnnotationLink.vtkAnnotationLink_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnnotationLink = (vtkAnnotationLink)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnnotationLink.Register(null);
				}
			}
			return vtkAnnotationLink;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAnnotationLink_SetAnnotationLayers_14(HandleRef pThis, HandleRef layers);

		public virtual void SetAnnotationLayers(vtkAnnotationLayers layers)
		{
			vtkAnnotationLink.vtkAnnotationLink_SetAnnotationLayers_14(base.GetCppThis(), (layers == null) ? default(HandleRef) : layers.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAnnotationLink_SetCurrentSelection_15(HandleRef pThis, HandleRef sel);

		public virtual void SetCurrentSelection(vtkSelection sel)
		{
			vtkAnnotationLink.vtkAnnotationLink_SetCurrentSelection_15(base.GetCppThis(), (sel == null) ? default(HandleRef) : sel.GetCppThis());
		}
	}
}

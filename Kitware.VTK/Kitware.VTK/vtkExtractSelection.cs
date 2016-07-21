using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractSelection : vtkExtractSelectionBase
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractSelection";

		public new static readonly string MRClassNameKey;

		static vtkExtractSelection()
		{
			vtkExtractSelection.MRClassNameKey = "class vtkExtractSelection";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractSelection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractSelection"));
		}

		public vtkExtractSelection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractSelection New()
		{
			vtkExtractSelection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelection.vtkExtractSelection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtractSelection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtractSelection.vtkExtractSelection_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelection_GetShowBounds_01(HandleRef pThis);

		public virtual int GetShowBounds()
		{
			return vtkExtractSelection.vtkExtractSelection_GetShowBounds_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelection_GetUseProbeForLocations_02(HandleRef pThis);

		public virtual int GetUseProbeForLocations()
		{
			return vtkExtractSelection.vtkExtractSelection_GetUseProbeForLocations_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelection_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractSelection.vtkExtractSelection_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractSelection_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractSelection.vtkExtractSelection_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelection_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractSelection NewInstance()
		{
			vtkExtractSelection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelection.vtkExtractSelection_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelection_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractSelection SafeDownCast(vtkObjectBase o)
		{
			vtkExtractSelection vtkExtractSelection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelection.vtkExtractSelection_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractSelection = (vtkExtractSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractSelection.Register(null);
				}
			}
			return vtkExtractSelection;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractSelection_SetShowBounds_08(HandleRef pThis, int _arg);

		public virtual void SetShowBounds(int _arg)
		{
			vtkExtractSelection.vtkExtractSelection_SetShowBounds_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractSelection_SetUseProbeForLocations_09(HandleRef pThis, int _arg);

		public virtual void SetUseProbeForLocations(int _arg)
		{
			vtkExtractSelection.vtkExtractSelection_SetUseProbeForLocations_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractSelection_ShowBoundsOff_10(HandleRef pThis);

		public virtual void ShowBoundsOff()
		{
			vtkExtractSelection.vtkExtractSelection_ShowBoundsOff_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractSelection_ShowBoundsOn_11(HandleRef pThis);

		public virtual void ShowBoundsOn()
		{
			vtkExtractSelection.vtkExtractSelection_ShowBoundsOn_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractSelection_UseProbeForLocationsOff_12(HandleRef pThis);

		public virtual void UseProbeForLocationsOff()
		{
			vtkExtractSelection.vtkExtractSelection_UseProbeForLocationsOff_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractSelection_UseProbeForLocationsOn_13(HandleRef pThis);

		public virtual void UseProbeForLocationsOn()
		{
			vtkExtractSelection.vtkExtractSelection_UseProbeForLocationsOn_13(base.GetCppThis());
		}
	}
}

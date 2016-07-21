using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRectilinearGridClip : vtkRectilinearGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRectilinearGridClip";

		public new static readonly string MRClassNameKey;

		static vtkRectilinearGridClip()
		{
			vtkRectilinearGridClip.MRClassNameKey = "class vtkRectilinearGridClip";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRectilinearGridClip.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectilinearGridClip"));
		}

		public vtkRectilinearGridClip(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearGridClip_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRectilinearGridClip New()
		{
			vtkRectilinearGridClip result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearGridClip.vtkRectilinearGridClip_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearGridClip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRectilinearGridClip() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRectilinearGridClip.vtkRectilinearGridClip_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearGridClip_ClipDataOff_01(HandleRef pThis);

		public virtual void ClipDataOff()
		{
			vtkRectilinearGridClip.vtkRectilinearGridClip_ClipDataOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearGridClip_ClipDataOn_02(HandleRef pThis);

		public virtual void ClipDataOn()
		{
			vtkRectilinearGridClip.vtkRectilinearGridClip_ClipDataOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRectilinearGridClip_GetClipData_03(HandleRef pThis);

		public virtual int GetClipData()
		{
			return vtkRectilinearGridClip.vtkRectilinearGridClip_GetClipData_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearGridClip_GetOutputWholeExtent_04(HandleRef pThis, IntPtr extent);

		public void GetOutputWholeExtent(IntPtr extent)
		{
			vtkRectilinearGridClip.vtkRectilinearGridClip_GetOutputWholeExtent_04(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearGridClip_GetOutputWholeExtent_05(HandleRef pThis);

		public IntPtr GetOutputWholeExtent()
		{
			return vtkRectilinearGridClip.vtkRectilinearGridClip_GetOutputWholeExtent_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRectilinearGridClip_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRectilinearGridClip.vtkRectilinearGridClip_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRectilinearGridClip_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRectilinearGridClip.vtkRectilinearGridClip_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearGridClip_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRectilinearGridClip NewInstance()
		{
			vtkRectilinearGridClip result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearGridClip.vtkRectilinearGridClip_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearGridClip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearGridClip_ResetOutputWholeExtent_10(HandleRef pThis);

		public void ResetOutputWholeExtent()
		{
			vtkRectilinearGridClip.vtkRectilinearGridClip_ResetOutputWholeExtent_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearGridClip_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRectilinearGridClip SafeDownCast(vtkObjectBase o)
		{
			vtkRectilinearGridClip vtkRectilinearGridClip = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearGridClip.vtkRectilinearGridClip_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGridClip = (vtkRectilinearGridClip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGridClip.Register(null);
				}
			}
			return vtkRectilinearGridClip;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearGridClip_SetClipData_12(HandleRef pThis, int _arg);

		public virtual void SetClipData(int _arg)
		{
			vtkRectilinearGridClip.vtkRectilinearGridClip_SetClipData_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearGridClip_SetOutputWholeExtent_13(HandleRef pThis, IntPtr extent, HandleRef outInfo);

		public void SetOutputWholeExtent(IntPtr extent, vtkInformation outInfo)
		{
			vtkRectilinearGridClip.vtkRectilinearGridClip_SetOutputWholeExtent_13(base.GetCppThis(), extent, (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearGridClip_SetOutputWholeExtent_14(HandleRef pThis, int minX, int maxX, int minY, int maxY, int minZ, int maxZ);

		public void SetOutputWholeExtent(int minX, int maxX, int minY, int maxY, int minZ, int maxZ)
		{
			vtkRectilinearGridClip.vtkRectilinearGridClip_SetOutputWholeExtent_14(base.GetCppThis(), minX, maxX, minY, maxY, minZ, maxZ);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearGridClip_SetOutputWholeExtent_15(HandleRef pThis, int piece, int numPieces);

		public void SetOutputWholeExtent(int piece, int numPieces)
		{
			vtkRectilinearGridClip.vtkRectilinearGridClip_SetOutputWholeExtent_15(base.GetCppThis(), piece, numPieces);
		}
	}
}

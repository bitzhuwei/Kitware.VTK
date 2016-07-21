using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStructuredGridClip : vtkStructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredGridClip";

		public new static readonly string MRClassNameKey;

		static vtkStructuredGridClip()
		{
			vtkStructuredGridClip.MRClassNameKey = "class vtkStructuredGridClip";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredGridClip.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredGridClip"));
		}

		public vtkStructuredGridClip(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGridClip_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStructuredGridClip New()
		{
			vtkStructuredGridClip result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGridClip.vtkStructuredGridClip_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGridClip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkStructuredGridClip() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkStructuredGridClip.vtkStructuredGridClip_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStructuredGridClip_ClipDataOff_01(HandleRef pThis);

		public virtual void ClipDataOff()
		{
			vtkStructuredGridClip.vtkStructuredGridClip_ClipDataOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStructuredGridClip_ClipDataOn_02(HandleRef pThis);

		public virtual void ClipDataOn()
		{
			vtkStructuredGridClip.vtkStructuredGridClip_ClipDataOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStructuredGridClip_GetClipData_03(HandleRef pThis);

		public virtual int GetClipData()
		{
			return vtkStructuredGridClip.vtkStructuredGridClip_GetClipData_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStructuredGridClip_GetOutputWholeExtent_04(HandleRef pThis, IntPtr extent);

		public void GetOutputWholeExtent(IntPtr extent)
		{
			vtkStructuredGridClip.vtkStructuredGridClip_GetOutputWholeExtent_04(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGridClip_GetOutputWholeExtent_05(HandleRef pThis);

		public IntPtr GetOutputWholeExtent()
		{
			return vtkStructuredGridClip.vtkStructuredGridClip_GetOutputWholeExtent_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStructuredGridClip_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStructuredGridClip.vtkStructuredGridClip_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStructuredGridClip_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStructuredGridClip.vtkStructuredGridClip_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGridClip_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStructuredGridClip NewInstance()
		{
			vtkStructuredGridClip result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGridClip.vtkStructuredGridClip_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGridClip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStructuredGridClip_ResetOutputWholeExtent_10(HandleRef pThis);

		public void ResetOutputWholeExtent()
		{
			vtkStructuredGridClip.vtkStructuredGridClip_ResetOutputWholeExtent_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGridClip_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStructuredGridClip SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredGridClip vtkStructuredGridClip = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGridClip.vtkStructuredGridClip_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGridClip = (vtkStructuredGridClip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGridClip.Register(null);
				}
			}
			return vtkStructuredGridClip;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStructuredGridClip_SetClipData_12(HandleRef pThis, int _arg);

		public virtual void SetClipData(int _arg)
		{
			vtkStructuredGridClip.vtkStructuredGridClip_SetClipData_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStructuredGridClip_SetOutputWholeExtent_13(HandleRef pThis, IntPtr extent, HandleRef outInfo);

		public void SetOutputWholeExtent(IntPtr extent, vtkInformation outInfo)
		{
			vtkStructuredGridClip.vtkStructuredGridClip_SetOutputWholeExtent_13(base.GetCppThis(), extent, (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStructuredGridClip_SetOutputWholeExtent_14(HandleRef pThis, int minX, int maxX, int minY, int maxY, int minZ, int maxZ);

		public void SetOutputWholeExtent(int minX, int maxX, int minY, int maxY, int minZ, int maxZ)
		{
			vtkStructuredGridClip.vtkStructuredGridClip_SetOutputWholeExtent_14(base.GetCppThis(), minX, maxX, minY, maxY, minZ, maxZ);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStructuredGridClip_SetOutputWholeExtent_15(HandleRef pThis, int piece, int numPieces);

		public void SetOutputWholeExtent(int piece, int numPieces)
		{
			vtkStructuredGridClip.vtkStructuredGridClip_SetOutputWholeExtent_15(base.GetCppThis(), piece, numPieces);
		}
	}
}

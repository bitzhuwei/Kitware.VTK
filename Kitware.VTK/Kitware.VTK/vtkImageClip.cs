using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageClip : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageClip";

		public new static readonly string MRClassNameKey;

		static vtkImageClip()
		{
			vtkImageClip.MRClassNameKey = "class vtkImageClip";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageClip.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageClip"));
		}

		public vtkImageClip(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageClip_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageClip New()
		{
			vtkImageClip result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageClip.vtkImageClip_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageClip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageClip() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageClip.vtkImageClip_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageClip_ClipDataOff_01(HandleRef pThis);

		public virtual void ClipDataOff()
		{
			vtkImageClip.vtkImageClip_ClipDataOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageClip_ClipDataOn_02(HandleRef pThis);

		public virtual void ClipDataOn()
		{
			vtkImageClip.vtkImageClip_ClipDataOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageClip_GetClipData_03(HandleRef pThis);

		public virtual int GetClipData()
		{
			return vtkImageClip.vtkImageClip_GetClipData_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageClip_GetOutputWholeExtent_04(HandleRef pThis, IntPtr extent);

		public void GetOutputWholeExtent(IntPtr extent)
		{
			vtkImageClip.vtkImageClip_GetOutputWholeExtent_04(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageClip_GetOutputWholeExtent_05(HandleRef pThis);

		public int[] GetOutputWholeExtent()
		{
			IntPtr intPtr = vtkImageClip.vtkImageClip_GetOutputWholeExtent_05(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageClip_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageClip.vtkImageClip_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageClip_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageClip.vtkImageClip_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageClip_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageClip NewInstance()
		{
			vtkImageClip result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageClip.vtkImageClip_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageClip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageClip_ResetOutputWholeExtent_10(HandleRef pThis);

		public void ResetOutputWholeExtent()
		{
			vtkImageClip.vtkImageClip_ResetOutputWholeExtent_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageClip_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageClip SafeDownCast(vtkObjectBase o)
		{
			vtkImageClip vtkImageClip = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageClip.vtkImageClip_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageClip = (vtkImageClip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageClip.Register(null);
				}
			}
			return vtkImageClip;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageClip_SetClipData_12(HandleRef pThis, int _arg);

		public virtual void SetClipData(int _arg)
		{
			vtkImageClip.vtkImageClip_SetClipData_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageClip_SetOutputWholeExtent_13(HandleRef pThis, IntPtr extent, HandleRef outInfo);

		public void SetOutputWholeExtent(IntPtr extent, vtkInformation outInfo)
		{
			vtkImageClip.vtkImageClip_SetOutputWholeExtent_13(base.GetCppThis(), extent, (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageClip_SetOutputWholeExtent_14(HandleRef pThis, int minX, int maxX, int minY, int maxY, int minZ, int maxZ);

		public void SetOutputWholeExtent(int minX, int maxX, int minY, int maxY, int minZ, int maxZ)
		{
			vtkImageClip.vtkImageClip_SetOutputWholeExtent_14(base.GetCppThis(), minX, maxX, minY, maxY, minZ, maxZ);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageClip_SetOutputWholeExtent_15(HandleRef pThis, int piece, int numPieces);

		public void SetOutputWholeExtent(int piece, int numPieces)
		{
			vtkImageClip.vtkImageClip_SetOutputWholeExtent_15(base.GetCppThis(), piece, numPieces);
		}
	}
}
